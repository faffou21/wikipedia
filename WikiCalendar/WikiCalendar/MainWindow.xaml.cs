﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace WikiCalendar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		Controller control;
        public MainWindow()
        {
            InitializeComponent();
			control = new Controller();
        }
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			String inputPath =
				//@"D:\downNew\wiki\enwiki-latest-pages-articles1.xml-p000000010p000010000";
				@"..\..\..\..\Data\sample_input_enwiki-latest-pages-articles1.xml";
			//	@"D:\downNew\wikienwiki-latest-pages-articles6.xml-p000185003p000305000";
			
			String exportPath = @"..\..\..\..\Data\sample_output_enwiki-latest-pages-articles1_Real_output.xml";
			
			control.initParsing(inputPath);
			control.exportEventsXML(exportPath);
			TextConsole.Text = control.getXmlString();
			pagesCountTextBox.Text = control.pagesCount.ToString();
			eventsCountTextBox.Text = control.eventsCount.ToString();

		}

	
    }
}
