/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the MKApplication JanitorHelper project.
 *
 * Created: 28. October 2014
 * Authors: Marko Kylmalahti
 */

using System.Windows;
using MKApplication.Entities;

namespace MKApplication
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class JanitorHelperGUI : Window
  {
    public JanitorHelperGUI()
    {
      InitializeComponent();

      this.instance = new JanitorHelperApplication();

      // Set title for graphical interface.
      this.Title = JanitorHelperApplication.Instance.ApplicationName + " " + JanitorHelperApplication.Instance.ApplicationVersion;

      Customer cust = new Customer() { FirstName = "Marko", LastName = "Kylmälahti", BirthDay = new System.DateTime(1980, 7, 16), Id = "-093L" };
      MessageBox.Show(cust.ToString());
    }

    private JanitorHelperApplication instance;
  }

} // MKApplication