/*
 * Copyright (C) Marko Kylmälahti
 *
 * This file is part of the MKApplication Main project.
 *
 * Created: 28. October 2014
 * Authors: Marko Kylmalahti
 */

namespace MKApplication
{
  public abstract class MainApplication
    : CoreApplication
  {
    #region     CONSTRUCTORS

    /// <summary>Creates a new instance.</summary>
    /// <remarks>Initializes the <see cref="Instance"/> to <c>this</c> if it is <c>null</c>.</remarks>
    protected MainApplication()
    {
      if (instance == null)
        instance = this;
    }

    #endregion   CONSTRUCTORS

    #region      STATIC PROPERTIES

    /// <summary>Gets the current <c>MainApplication</c> instance.</summary>
    internal static MainApplication Instance { get { return instance; } }

    #endregion    STATIC PROPERTIES

    #region       STATIC FIELDS

    /// <summary>The current <c>MainApplication</c> instance.</summary>
    private static MainApplication instance;

    #endregion    STATIC FILEDS
  }
}
