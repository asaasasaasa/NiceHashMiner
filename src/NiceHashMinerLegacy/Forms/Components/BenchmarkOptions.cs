﻿using System;
using System.Windows.Forms;
using NiceHashMinerLegacy.Common.Enums;


namespace NiceHashMiner.Forms.Components
{
    public partial class BenchmarkOptions : UserControl
    {
        public BenchmarkPerformanceType PerformanceType { get; private set; }

        public BenchmarkOptions()
        {
            InitializeComponent();
        }

        public void SetPerformanceType(BenchmarkPerformanceType performanceType)
        {
            switch (performanceType)
            {
                case BenchmarkPerformanceType.Quick:
                    radioButton_QuickBenchmark.Checked = true;
                    PerformanceType = BenchmarkPerformanceType.Quick;
                    break;
                case BenchmarkPerformanceType.Standard:
                    radioButton_StandardBenchmark.Checked = true;
                    PerformanceType = BenchmarkPerformanceType.Standard;
                    break;
                case BenchmarkPerformanceType.Precise:
                    radioButton_PreciseBenchmark.Checked = true;
                    PerformanceType = BenchmarkPerformanceType.Precise;
                    break;
                default:
                    radioButton_StandardBenchmark.Checked = true;
                    break;
            }
        }

        public void InitLocale()
        {
            groupBox1.Text = Translations.Tr("Benchmark Type:");
            radioButton_QuickBenchmark.Text = Translations.Tr("&Quick (can be inaccurate)");
            radioButton_StandardBenchmark.Text = Translations.Tr("&Standard");
            radioButton_PreciseBenchmark.Text = Translations.Tr("&Precise (will take longer)");
        }

        private void RadioButton_QuickBenchmark_CheckedChanged(object sender, EventArgs e)
        {
            PerformanceType = BenchmarkPerformanceType.Quick;
        }

        private void RadioButton_StandardBenchmark_CheckedChanged(object sender, EventArgs e)
        {
            PerformanceType = BenchmarkPerformanceType.Standard;
        }

        private void RadioButton_PreciseBenchmark_CheckedChanged(object sender, EventArgs e)
        {
            PerformanceType = BenchmarkPerformanceType.Precise;
        }
    }
}
