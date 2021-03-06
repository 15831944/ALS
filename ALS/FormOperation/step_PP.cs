﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ALS.FormOperation
{
    public partial class step_PP : UserControl
    { 
        public delegate void StartRecycle(object sender, EventArgs e);
        public event StartRecycle _StartRecycle;

        public delegate void PPSteps(object sender, EventArgs e);
        public event PPSteps _PPSteps;

        public delegate void SelectStepChanged(object sender, EventArgs e);
        public event SelectStepChanged _SelectStepChanged;

        public delegate void SPSet(object sender, EventArgs e);
        public event SPSet _SPSet;

        /// <summary>
        /// 压力值范围模型
        /// </summary>
        private Model.treatmentmode _modelTreat;
        public Model.treatmentmode _ModelTreat
        {
            get { return _modelTreat; }
            set { _modelTreat = value; }
        }

        private SerialPort _port_ppump;
        /// <summary>
        /// 蠕动泵通讯端口
        /// </summary>
        public SerialPort _Port_ppump
        {
            get { return _port_ppump; }
            set { _port_ppump = value; }
        }

        public step_PP()
        {
            InitializeComponent();
        }
        

        public void ReadSet()
        {
            this.lblTargetBPSpeed.Text = _modelTreat.LeadBloodSpeed.Value.ToString("f0");
        }
 

        private void btnStartPP_Click(object sender, EventArgs e)
        {
            this.btnStartPP.Enabled = false;
            this.btnPausePP.Enabled = true; 
            this.wizardPage2.AllowNext = false; 
            this.wizardPage2.AllowBack = false;
            if (_PPSteps != null)
                _PPSteps(sender, e);
        }
  
        public void btnPausePP_Click(object sender, EventArgs e)
        {
            this.btnStartPP.Enabled = true;
            this.btnPausePP.Enabled = false; 
            this.wizardPage2.AllowBack = true;
            this.wizardPage2.AllowNext = true; 
            if (_PPSteps != null)
                _PPSteps(sender, e);
       
        }

        private void step_PE_Load(object sender, EventArgs e)
        {
            ReadSet();
        }

        private void wizardControl1_Finished(object sender, EventArgs e)
        {
            if (_StartRecycle != null)
                _StartRecycle(sender, e);
        }

        private void wizardControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (_SelectStepChanged != null)
                _SelectStepChanged(sender, e);
        }

        private void wizardControl1_Cancelling(object sender, CancelEventArgs e)
        {
            if (_SPSet != null)
                _SPSet(sender, e);
        } 
    }
}
