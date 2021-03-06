﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19Radar.Models
{
    public class InfectionProcessModel
    {
        /// <summary>
        /// for Cosmos DB
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// PartitionKey
        /// </summary>
        public string PartitionKey { get; set; }

        /// <summary>
        /// User UUID / take care misunderstand Becon ID
        /// </summary>
        /// <value>User UUID</value>
        public string UserUuid { get; set; }

        /// <summary>
        /// User Major 0 to 65536
        /// </summary>
        /// <value>User Major</value>
        public string Major { get; set; }

        /// <summary>
        /// User Minor 0 to 65536
        /// </summary>
        /// <value>User Minor</value>
        public string Minor { get; set; }

        /// <summary>
        /// Processing number for regist
        /// </summary>
        public string ProcessingNumber { get; set; }

    }
}
