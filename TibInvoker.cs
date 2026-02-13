// ***********************************************************************
// Assembly         : Tib.Api
// Author           : cboivin
// Created          : 05-15-2019
//
// Last Modified By : cboivin
// Last Modified On : 05-15-2019
// ***********************************************************************
// <copyright file="TibInvoker.cs" company="Tib.finance">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tib.Api
{
  /// <summary>
  /// Class TibInvoker.
  /// </summary>
  public static class TibInvoker
  {
    /// <summary>
    /// The portal
    /// </summary>
    private static PortalInvoker _portal = null;

    /// <summary>
    /// Initializes the portal.
    /// </summary>
    /// <param name="siteUrl">The site URL.</param>
    public static void InitializePortal(string siteUrl)
    {
      _portal = new PortalInvoker();
      _portal.SetSiteUrl(siteUrl);
    }

    /// <summary>
    /// Gets the portal.
    /// </summary>
    /// <value>The portal.</value>
    public static PortalInvoker Portal
    {
      get
      {
        return _portal;
      }
    }
  }
}
