/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the MKApplication Core project.
 *
 * Created: 28. October 2014
 * Authors: Marko Kylmalahti
 */

namespace MKApplication
{
  public abstract class CoreApplication
  {

    #region    CONSTRUCTORS

    /// <summary>Creates a new instance.</summary>
    /// <remarks>Initializes the <see cref="Instance"/> to <c>this</c> if it is <c>null</c>.</remarks>
    protected CoreApplication()
    {
      if (instance == null)
        instance = this;
    } 

    #endregion CONSTRUCTORS

    #region    PROPERTIES

    /// <summary>Gets the name of the current implemented application.</summary>
    public abstract string ApplicationName { get; }

    /// <summary>Gets the version of the current implemented application.</summary>
    public abstract string ApplicationVersion { get; } 

    #endregion    PROPERTIES

    #region     STATIC PROPERTIES

    /// <summary>Gets the current <c>CoreApplication</c> instance.</summary>
    internal static CoreApplication Instance { get { return instance; } } 

    #endregion  STATIC PROPERTIES

    #region     STATIC FIELDS

    /// <summary>The current <c>CoreApplication</c> instance.</summary>
    private static CoreApplication instance;

    #endregion  STATIC FILEDS

  }

} // MKApplication