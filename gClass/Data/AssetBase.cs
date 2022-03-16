﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gClass
{

    [Serializable]
    public class AssetBase
    {
        [Key]
        public int AssetBaseId { get; set; }
        public Guid id { get; set; }
        public Guid logicid { get; set; }
        public string ip { get; set; }
        public string GroupName { get; set; }
        public string ZoneName { get; set; }
        public string SpeakerName { get; set; }
        public string ch { get; set; }
        public string path { get; set; }
        public string floor { get; set; }
        public string DeviceName { get; set; }
        public string state { get; set; } // On-Line , Off-Line
        public string state_old { get; set; } // On-Line , Off-Line
        public bool chk { get; set; }
        public int seq { get; set; }

        public int AssetGroupId { get; set; }
        public AssetGroup assetGroup { get; set; }
        //public int PlayItemId { get; set; }
        //public PlayItem playItem { get; set; }

        public AssetBase()
        {
            //id = Guid.NewGuid();
            ip = "";
            DeviceName = "";
            floor = "";
            state = "";
            state_old = "";
            seq = 0;
        }

    }

}
