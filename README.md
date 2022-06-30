<h1 align="center">Tesla Demo</h1>

<div align="center">
  :heart:
</div>

<br />

<div align="center">
  <strong>A Windows Presentation Foundation Application</strong>
</div>
<div align="center">
  A <code>C#</code> code base, with a modern feel
</div>

<br />

<div align="center">
  <!-- Stability -->
  <a>
    <img src="https://img.shields.io/badge/stability-experimental-orange.svg?style=flat-square"
      alt="Application Stability" />
  </a>
  <!-- Downloads -->
  <a>
    <img src="https://img.shields.io/github/downloads/computesam/Tesla-Demo/total?style=flat-square"
      alt="Downloads" />
  </a>
  <!-- Standard -->
  <a>
    <img src="https://img.shields.io/badge/codestyle-MVVM-brightgreen.svg?style=flat-square"
      alt="MVVM" />
  </a>
</div>

<div align="center">
  <h3>
    <a href="https://twitter.com/miohsam">
      Twitter
    </a>
    <span> | </span>
    <a href="https://www.youtube.com/channel/UCaQ8KHH3f5UWssiqQfihVjA?sub_confirmation=1">
      YouTube
    </a>
    <span> | </span>
    <a href="https://instagram.com/ComputeSam">
      Instagram
    </a>
  </h3>
</div>

<div align="center">
  <sub>Finally. A proper Tesla UI.
  <a></a>
  </a>
</div>

## Table of Contents
- [Features](#features)
- [Example](#examples)
- [Optimizations](#optimizations)
- [FAQ](#faq)
- [Installation](#installation)
- [Support](#support)

## Features
- __Minimal Size:__ weighing `24MB`, This Demo is portable and simple!
- __MVVM:__ allows for better functionallity when needed in WPF.
- __Possibilities:__ universal structure and layout.
- __UX/UI:__ a beautiful `modern design`, I have worked on this for over a year.
- __MAUI:__ should be fairly portable to .NET MAUI, whenever Microsoft decides to release this IDE feature in full...
- __Tesla Related:__ enjoy a Tesla like experience.

## Examples
![Familiar Design and Feel](https://i.imgur.com/viJSzW5.gif)
<br />
## Design that fits
![Completely Custom Light & Dark Mode](https://i.imgur.com/9yTz0Ap.png)
&nbsp;&nbsp;&nbsp;&nbsp;
![Completely Custom Light & Dark Mode](https://i.imgur.com/gimKuBs.png)
<br />
Want to see more? Check out the [Initial Release](https://github.com/computesam/Tesla-Demo/releases/tag/v1.0.0-Release).

## Optimizations
```c#
namespace Tesla_Demo
{
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            DataContext = new MainViewModel();
        }

        private void GetBatteryPercent()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Battery");
            var allBatteries = wmi.GetInstances();

            foreach (var battery in allBatteries)
            {
                int estimatedChargeRemaining = Convert.ToInt32(battery["EstimatedChargeRemaining"]);

                double batteryProgress = Convert.ToDouble(battery["EstimatedChargeRemaining"]);

                BatteryPercent_Text.Text = estimatedChargeRemaining.ToString() + "%";

                BatteryProgress.Value = batteryProgress;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetBatteryPercent();
        }
```

Multi-Thread Optimizations are used for a fast and snappy UI


## FAQ

### Why is this needed?
Because I admire design language.
I also have not come across a well rounded Tesla desktop application.
I am going to be working on implementing API Communication.


### Is this safe?
yes. obv.

### Mac Release?
This is not likely until Microsoft releases .NET MAUI in full. 
I will work on porting this when that happens. But until then, just `relax`.

## Support
My Twitter and Instagram can be found at the top of this README.
Please reach out to me with any questions or concerns you may come across.

## Installation
The only prerequisite is [.NET Runtime 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

## License
[GNU 3](https://www.gnu.org/licenses/gpl-3.0.html)
