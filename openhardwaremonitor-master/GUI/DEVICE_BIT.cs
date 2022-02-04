/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2020 Michael Möller <mmoeller@openhardwaremonitor.org>
	Copyright (C) 2010 Paul Werelds <paul@werelds.net>
	Copyright (C) 2012 Prince Samuel <prince.samuel@gmail.com>

*/

using System;


namespace OpenHardwareMonitor.GUI {
   class DEVICE_BIT {

    //  USB
    public string[] usb_name = new string[30];
    public string[] usb_vid = new string[30];
    public string[] usb_pid = new string[30];
    public int usbCount;

    //  HDMI
    public Boolean hdmi_connect;

    public string[] com_name = new string[20];
    public string[] com_vid = new string[20];
    public string[] com_pid = new string[20];
    public int comCount;

    // BATTERY
    public string Battery_name;
    public int battery_volume;
    

    public DEVICE_BIT() {

    }

    public string this[int Index]{
      get
      {
        return usb_name[Index];

      }
      set
      {
        usb_name[Index] = value;
      }
    }

    //public string this[int index] {
    //  get => vid[index];
    //  set => vid[index] = value;
    //}

    //public string this[int index] {
    //  get => pid[index];
    //  set => pid[index] = value;
    //}

    public int UsbCount {
      get => usbCount;
      set => usbCount = value;
    }
  }
}
