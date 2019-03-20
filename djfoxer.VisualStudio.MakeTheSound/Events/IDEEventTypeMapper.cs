﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djfoxer.VisualStudio.MakeTheSound.Events
{
    public class IDEEventTypeMapper
    {
        private const string Action_SaveAll = "File.SaveAll";
        private const string Action_Save = "File.SaveSelectedItems";

        public static string IDEEventTypeToSoundPath(IDEEventType iDEEventType)
        {
            string path = string.Empty;

            switch (iDEEventType)
            {
                case IDEEventType.Unknown:
                    path = "ohno!";
                    break;
                default:
                    path = iDEEventType.ToString();
                    break;
            }
            return $"./Audio/{path}.wav";
        }

        public static string IDEEventTypeToVSAction(IDEEventType iDEEventType)
        {
            switch (iDEEventType)
            {
                case IDEEventType.FileSave:
                    return Action_Save;
                case IDEEventType.FileSaveAll:
                    return Action_SaveAll;
                case IDEEventType.Unknown:
                default:
                    return string.Empty;
            }
        }
    }
}
