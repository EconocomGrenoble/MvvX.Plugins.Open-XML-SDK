﻿using MvvX.Plugins.Open_XML_SDK.Core.Word.Models;

namespace MvvX.Plugins.Open_XML_SDK.Core.Word.Tables.Models
{
    public class TablePropertiesModel
    {
        /// <summary>
        /// Style of the table
        /// default : TableGrid
        /// </summary>
        public TableStyleModel TableStyle { get; set; }

        public TableBordersModel TableBorders { get; set; }

        public TableWidthModel TableWidth { get; set; }

        public ShadingModel Shading { get; set; }

        /// <summary>
        /// Justification of the table
        /// default : Center
        /// </summary>
        public TableRowAlignmentValues TableJustification { get; set; }
        
        public TablePropertiesModel()
        {
            TableStyle = new TableStyleModel();
            TableJustification = TableRowAlignmentValues.Center;
        }
    }
}
