﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OpenXMLSDK.Engine.Word.ReportEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace OpenXMLSDK.UnitTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void MyUnitTest () {
            Mock<AlternateRowCellConfiguration> mockAlternate = new Mock<AlternateRowCellConfiguration> ();

            AlternateRowCellConfiguration mockObject = mockAlternate.Object;

            Assert.Fail ();
        }
    }
}