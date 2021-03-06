using DataClass;
using gClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using Wisej.CodeProject;
using Wisej.CodeProject.DataSet1TableAdapters;
using static Wisej.CodeProject.DataSet1;

namespace pa
{
    //
    // 리시브 시그날알 처리 
    //

    public partial class MainWindow : Window
    {
        internal async Task<bool> RcvSigR(SignalRMsg msg)
        {
            int chno = 0;

            switch (msg.Msgtype)
            {
                case eSignalRMsgType.eEM:
                    break;
                case eSignalRMsgType.eEM_FIRE:
                    break;
                case eSignalRMsgType.eEM_PRESET_SW:
                    break;
                // 1. 빈 채널 받고, 2. 디비 만들고, 3. 빈채널 셋팅하고
                // 4. 스피커 셋팅하고 , 5. 방송 처리 
                case eSignalRMsgType.ePlay:
                    List<AssetBase> play = new List<AssetBase>();
                    chno = EmptyChFind();
                    if (chno == 0) return false;
                    play = dBSqlite.db2List(msg, chno);
                    ChSet(chno);

                    var p =  g.playItems[chno];
                    {
                        p.chno = chno;
                        p.idno = 100000 + chno;
                        p.Play = play;
                        p.Guid = msg.Guid;
                    }

                    // 스피커 셋팅후 플레이 처리 
                    g.DSP_MakeGroupSpeaker(p.Play, 1, BS_DSP_STATE.MUL_BS, p.chno);
                    PlayChildProcess(p.chno, p.idno);

                    string line1 = string.Join(",", msg.assetsRows.ToArray());
                    string line2 = string.Join(",", msg.musicsRows.ToArray());

                    string line = line1 + " : " + line2;
                    string l1 = "다원방송시작";
                    g.Log(l1 + p.chno.ToString() + " : " + line);
                    dBSqlite.Eventvm(l1, p.chno.ToString() + "번 채널", line);
                    // window3 처리 
                    break;
                case eSignalRMsgType.ePlayEnd:
                    break;
                case eSignalRMsgType.ePlaying:
                    break;
                case eSignalRMsgType.eStop:
                    chno = getplay(msg.Guid);
                    MBSStop(chno);
                    break;
                case eSignalRMsgType.eVolume:
                    // db 처리 선행 필요 
                    InitVolume();
                    break;
                case eSignalRMsgType.eOutChMove:
                    SpeakerAssignDSP(msg.message, msg.user_data1, msg.state, msg.user_data4);
                    g.Log("eOutChMove" + " : " + msg.message + " : " + msg.user_data1 + " : " + msg.state.ToString() + " : " + msg.user_data4.ToString());
                    break;
                case eSignalRMsgType.eInChMove:
                    MoveInputChannel(msg.user_data1, msg.state, msg.message, msg.user_data4);
                    g.Log("eInChMove" + " : " + msg.user_data1 + " : " + msg.state.ToString() + " : " + msg.message + " : " + msg.user_data4.ToString());
                    break;
                case eSignalRMsgType.eScanAll:
                    if (ScanAll())
                    {
                        g.SendSigR(eSignalRMsgType.eReturn, "Server : 전체스캔 처리중 입니다. 약 5분정도 소요될 예정입니다");
                        g.Log("eScanAll");
                    }
                    else
                    {
                        g.SendSigR(eSignalRMsgType.eReturn, "Server : 처리(진행)중 입니다.");
                    }
                    break;
            }
            return true;
        }

        private int getplay(Guid guid)
        {
            int rlt = 0;
            for (int i = 2; i < 9; i++)
            {
                PlayItem pl1 = g.playItems[i];
                if (pl1.Guid == guid)
                { 
                    return i;
                }
            }
            return rlt;
        }

        private void ChSet(int chno)
        {
            g.playItems[chno] = new PlayItem();
            g.playItems[chno].p_run = true;
            g.playItems[chno].idno = 100000 + chno;
            g.playItems[chno].state = "대기";
            g.playItems[chno].chno = chno;
        }

        // 빈채널 찾기 
        private int EmptyChFind()
        {
            int rlt = 0;
            for (int i = 2; i < 9; i++)
            {
                PlayItem pl1 = g.playItems[i];
                if (pl1.p_run)
                    continue;
                if (pl1.idno != 0)
                    continue;
                if (pl1.state != "대기")
                    continue;
                rlt = i;
                break;
            }
            return rlt;
        }

    }
}
