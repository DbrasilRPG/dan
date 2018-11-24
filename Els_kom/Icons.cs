// Copyright (c) 2014-2018, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Els_kom
{
    using System.Drawing;
    using Els_kom.Properties;
    using Els_kom_Core.Classes;

    // Forms designer cannot see these if they are "internal" but I wanted them Internal.
    // The WinForms team probably should base the Forms Designer off of Roslyn sometime?

    /// <summary>
    /// Els_kom Icon Resource Class.
    /// </summary>
    public static class Icons
    {
        /// <summary>
        /// Gets the form icon from the project's resources.
        /// </summary>
        /// <value>
        /// The form icon from the project's resources.
        /// </value>
        public static Icon FormIcon
        {
            get
            {
                var iconVal = string.Empty;
                XMLObject settingsxml = null;
                if (SettingsFile.Settingsxml == null)
                {
                    settingsxml = new XMLObject(SettingsFile.Path, "<Settings></Settings>");
                    iconVal = settingsxml.TryRead("WindowIcon");
                }
                else
                {
                    SettingsFile.Settingsxml.ReopenFile();
                    iconVal = SettingsFile.Settingsxml.TryRead("WindowIcon");
                }

                // dispose this temporary object.
                settingsxml = null;
                var retIcon = Resources.els_kom;
                if (iconVal.Equals("1"))
                {
                    retIcon = Resources.VP_Trans;
                }
                else if (iconVal.Equals("2"))
                {
                    retIcon = Resources.YR;
                }

                return retIcon;
            }
        }

        /// <summary>
        /// Gets a 48 x 48 sized <see cref="Image"/>
        /// from a icon in the project's resources.
        /// </summary>
        /// <value>
        /// A 48 x 48 sized <see cref="Image"/>
        /// from a icon in the project's resources.
        /// </value>
        public static Image FormImage
        {
            get
            {
                var iconVal = string.Empty;
                XMLObject settingsxml = null;
                if (SettingsFile.Settingsxml == null)
                {
                    settingsxml = new XMLObject(SettingsFile.Path, "<Settings></Settings>");
                    iconVal = settingsxml.TryRead("WindowIcon");
                }
                else
                {
                    SettingsFile.Settingsxml.ReopenFile();
                    iconVal = SettingsFile.Settingsxml.TryRead("WindowIcon");
                }

                // dispose this temporary object.
                settingsxml = null;
                var oldicon = Resources.els_kom;
                if (iconVal.Equals("1"))
                {
                    oldicon = Resources.VP_Trans;
                }
                else if (iconVal.Equals("2"))
                {
                    oldicon = Resources.YR;
                }

                var newicon = new Icon(oldicon, 48, 48);
                return newicon?.ToBitmap();
            }
        }
    }
}