<h1 align="center">
  <br>
  <a href="https://github.com/retched/TCG-Registration-Manager"><img src="https://i.imgur.com/d0BV0vR.png" alt="TCG+ Registration Helper"></a>
  <br>
  TCG+ Registration Helper
  <br>
</h1>

<h4 align="center">A CSV Helper tool to aid in registering for tournaments using BandaiTCG+.</h4>

<p align="center">
<a href="https://github.com/retched/TCG-Registration-Manager/tags/" target="_blank"><img src="https://badgen.net/github/release/retched/TCG-Registration-Manager/?color=9932cc"></a>
<a href="https://github.com/retched/TCG-Registration-Manager/issues" target="_blank"><img src="https://badgen.net/github/open-issues/retched/TCG-Registration-Manager/?color=9932cc"></a>
<a href="https://ko-fi.com/retched/" target="_blank"><img src="https://badgen.net/badge/icon/kofi?icon=kofi&label&color=9932cc"></a>
<img src="https://badgen.net/badge/icon/windows?icon=windows&label&color=9932cc">
<img src="https://img.shields.io/badge/language-vb.net-9932cc">
</p>


<p align="center">
  <a href="#key-features">Key Features</a> •
  <a href="#how-to-use">How To Use</a> •
  <a href="#download">Download</a> •
  <a href="#license">License</a> •
  <a href="#more-links">More Links</a>
</p>

## Author's Note - Software is no longer the only option
This software was originally made to aid tournament organizer's TCG+ activities relating to player management. Namely, same day registration without having to fuss with searching for the tournament in TCG+. 

As of April 2023, Bandai TCG+ has been modified to allow for in-person, last-minute registration of a player by using a feature on the player's TCG+ app. So this software is, in part, partially redundant. However, this software will continue to be maintained on the interim as the CSV import function is still available on TCG+ and provides an alternative to keying in random TOTP membership numbers (that may not sync correctly). Additionally, this software still has a pretty decent function for reporting and recording tournament penalties.

I encourage all tournament organizers to review the material made available to them in the TCG+ dashboard and learn the new registration process going forward.


## Example usage of software
![Sample Usage of TCG+ Registration Helper](https://i.imgur.com/sPmKnHZ.gif)

## Key Features

* Lessens the hassle of making your players pre-register for all TCG+ events. Instead allows you to create a CSV import file for uploading to the website which will register the players.
* Keeps track of any penalties that are being issued during the tournament.
  - Includes assigning staff to certain roles and maintaining a staff roster.
* Create Sign In sheets for keeping track of pre-registered players. _(Planned function coming in a later edition.)_
* Create a randomized list of players who will who separated off of one roster and registered to another.


## How To Use

To clone and run this application, you'll need [Git](https://git-scm.com) installed on your computer. Additionally, to build the executable you will need [Visual Studio 2022](https://visualstudio.microsoft.com/). (Any version of Visual Studio 2022 should do fine. Some editions of earlier Visual Studio should also be fine, but the `.sln` file is only available for Visual Studio 2022.)

Once installed or built, launch the program from a "safe" location. (ie. No anti-virus sandboxes and not from a protected directory (like Program Files). This is due to the program asking for elevated rights.)

For more details on the operation of the software, read the enclosed README PDF.

## Download

You can [download](https://github.com/retched/TCG-Registration-Manager/releases) the latest installable version of TCG+ Helper for Windows. Additionally, you can download the source code as a ZIP file.

## Sponsor

<a href='https://ko-fi.com/Y8Y65PLO' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://cdn.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a> 

## Contribution Guidelines
In general, we use the GitHub Flow for the process and storage of the source code. This means, all work should be submitted on the GitHub system. This includes Pull Requests, Bug Reporting, Feature Requests, and so on. 

Before creating a pull request, be sure the bug and/or feature is posted as an Issue and that you are assigned that Issue as a task.
* If a revelant issue exists, discuss the issue and get it assigned to yourself on GitHub.
* If no issue exists, open a new issue and assign it to yourself. (You shouldn't wait for it to be assigned to you.)

Be sure that when you are making your pull request that you mention that specific issue and request approval.

## License

    TCG+ Registration Helper. A program for TOs to make the
	most of Bandai TCG+ event registration system.
    Copyright (C) 2022, Paul Williams (retched@hotmail.com)

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
See `LICENSE.txt` for the full license.

### More Links
* [retchedlive.com](https://www.amitmerchant.com) &nbsp;&middot;&nbsp; Personal website and web blog
* GitHub [@retched](https://github.com/retched) &nbsp;&middot;&nbsp; Public projects and open sourced.
* GitLab [@retched](https://gitlab.com/retched) &nbsp;&middot;&nbsp; Private repositories
* Twitter [@retched](https://twitter.com/retched) &nbsp;&middot;&nbsp; Random musings
* Twitch  [@retched](https://twitch.tv/retched) &nbsp;&middot;&nbsp; Live coding, paired programming, video games.

Source Code: 

`Copyright © 2022-2023, Paul Williams, All rights reserved.`