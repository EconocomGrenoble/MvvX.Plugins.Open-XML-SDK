﻿using System.Collections.Generic;

namespace OpenXMLSDK.Engine.Word.ReportEngine.Models.Charts
{
    public class ChartSerie : BaseElement
    {
        /// <summary>
        /// Name of the serie
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Values
        /// </summary>
        public List<double?> Values { get; set; }
        
        /// <summary>
        /// Color of the serie
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Color of labels
        /// </summary>
        public string DataLabelColor { get; set; }

        /// <summary>
        /// Format de rendu des labels
        /// {0} par défaut
        /// </summary>
        public string LabelFormatString { get; set; } = "{0}";

        /// <summary>
        /// Define if the serie has a border
        /// </summary>
        public bool HasBorder { get; set; }

        /// <summary>
        /// Border color
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Border width
        /// </summary>
        public int? BorderWidth { get; set; }

        public ChartSerie()
            : base(typeof(ChartSerie).Name)
        {
        }
    }
}
