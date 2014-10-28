/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the MKApplication JanitorHelper project.
 *
 * Created: 28. October
 * Authors: Marko Kylmalahti
 */


namespace MKApplication
{
  public sealed class JanitorHelperApplication
    : MainApplication
  {

    #region     CONSTRUCTORS

    /// <summary>Creates a new instance.</summary>
    /// <remarks>Initializes the <see cref="Instance"/> to <c>this</c> if it is <c>null</c>.</remarks>
    public JanitorHelperApplication()
    {
      if (instance == null)
        instance = this;

    } 

    #endregion  CONSTRUCTORS

    #region     OVERRIDES

    /// <summary>Gets the name of this application.</summary>
    /// <seealso cref="JanitorHelper.Name"/>
    public override string ApplicationName
    {
      get { return JanitorHelperApplication.Name; }
    }

    /// <summary>Gets the current version of this application.</summary>
    /// <seealso cref="JanitorHelper.Version"/>
    public override string ApplicationVersion
    {
      get { return JanitorHelperApplication.Version; }
    }

    #endregion   OVERRIDES

    #region      CONSTANTS

    /// <summary>Name of this application.</summary>
    public const string Name = "JanitorHelper";

    /// <summary>Version of this application.</summary>
    public const string Version = "0.0.1"; 

    #endregion    CONSTANTS

    #region       STATIC METHODS

    /// <summary>Gets the current <c>JanitorHelperApplication</c> instance.</summary>
    internal static JanitorHelperApplication Instance { get { return instance; } } 

    #endregion    STATIC METHODS

    #region       STATIC FIELDS

    /// <summary>The current <c>JanitorHelperApplication</c> instance.</summary>
    private static JanitorHelperApplication instance;

    #endregion    STATIC FILEDS

  }
}
