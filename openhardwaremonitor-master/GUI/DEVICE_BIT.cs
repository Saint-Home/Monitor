/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2020 Michael Möller <mmoeller@openhardwaremonitor.org>
	Copyright (C) 2010 Paul Werelds <paul@werelds.net>
	Copyright (C) 2012 Prince Samuel <prince.samuel@gmail.com>

*/

using System;
using System.Collections.Generic;
using System.Linq;


namespace OpenHardwareMonitor.GUI {
   class DEVICE_BIT {

    //  USB
#if false // old
    public string[] usb_name = new string[30];
    public string[] usb_vid = new string[30];
    public string[] usb_pid = new string[30];
    public int usbCount;
#else
    // 딕셔너리
    public Dictionary<string, USBDictionary> usb_dic = new Dictionary<string, USBDictionary>();
#endif

    //  HDMI
    public Boolean hdmi_connect;


    //  COM
    public Dictionary<string, ComDictionary> com_dic = new Dictionary<string, ComDictionary>();

    // BATTERY
    private string battery_name;
    public string Battery_name { get; set; }

    private int battery_volume;
    public int Battery_volumes { get; set; }
    public DEVICE_BIT() {


    }

  }

}

public class ComDictionary {
  private string vid;
  private string pid;

  public string Vid { get; set; }
  public string Pid { get; set; }

}

public class USBDictionary {
  private string vid;
  public string Vid { get; set; }
  private string pid;
  public string Pid { get; set; }

  private string name;
  public string Name { get; set; }

  
  

}

