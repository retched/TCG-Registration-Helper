# UNOFFICIAL TCG+ REGISTRATION TOOL – README
Written by Paul Williams (<retched@hotmail.com>)

# About This Program
This program is meant to create CSV files for importing into the Bandai TCG+ website for Tournament Organizers (TO) to register players. Normally, players MUST use the app and website to pre-register for tournaments they wish to participate in. But if a player tries to register too late or pre-registers but does not show up to the event, this creates a bit of extra hassle for the organizer as they will have to remove each member that does not show up or (worse) register the player as a “guest” which doesn’t count towards Bandai’s metrics. 

Additionally, this program will also allow a TO and Scorekeeper to keep track of any penalties issued throughout the tournament by the tournament’s judge staff. 

While this program is a great tool to have, it is not the only way to create these kind of CSV files. In fact, if you’re savvy enough, you could even use programs like Microsoft Excel or (better) LibreOffice Calc to make the file for you.
# Program Overview at a Glance
![image](https://user-images.githubusercontent.com/1572532/188208729-23384cc4-be9f-4553-bcc0-2388b184117b.png)

![image](https://user-images.githubusercontent.com/1572532/188208745-5d1d088c-da5d-4e73-91d0-a2748b3ec3af.png)

# Getting Started
To begin…

1) You must be a sanctioned/registered Tournament Organizer/Store with Bandai TCG. 
1) You must have a stable internet connection. You must be able to connect to the website to upload the registration file and to run the actual tournament.
1) You must be aware of how the TCG+ website works. This guide will show you how to walk through certain parts of the website but overall, this guide will make the assumption that you are aware of at least how to manage your tournament via the software.

This program is only responsible for managing the tournament registration list. It will NOT (currently) make pairings or tournament brackets for you. (If you’re not a part of a Bandai TCG sanctioned store and wish to organize tournaments for any of Bandai’s games, might I suggest Best Coast Pairings’ Android or iOS apps or websites like Challonge and the like? This program nor the ones mentioned will let you report your tournament to Bandai but at least with Best Coast Pairings, you can at least offer your players a way to report results via the individual Player apps instead.)
## Installation
To install the software, simple unzip all parts of the .ZIP file using your preferred ZIP extractor program (WinZip, WinRAR, 7Zip, etc.) and extra the contents into a directory of your choosing. Preferably somewhere away from the Program Files directory. (Maybe in a subdirectory of your documents or downloads folder.) Be sure to unzip the AllPlayers.xml file as well as the .exe program file. These files MUST be in the same directory.
# Setting Up The Tournament
To start, you should visit the tournament in your store’s Bandai TCG+ panel by logging in to <https://distributor.bandai-tcg-plus.com> and clicking on “My Events”. Choose the tournament that you wish to register players for.

![image](https://user-images.githubusercontent.com/1572532/188208760-338e3884-2b3a-4458-b8ae-1149fb3bcc87.png)
*Figure 1. The Bandai TCG+ website.*

When you find the tournament that you wish to operate, click anywhere on the row with the details. From here you will be taken to the “My Event Details” screen. (This should be a row that says “Accepting Applications”.) Make sure to select the event for the event’s date. There won’t be a hyperlink nor will your mouse cursor act as if it was a hyperlink.

![image](https://user-images.githubusercontent.com/1572532/188208785-12b31834-a43e-403f-a35f-39778ac793be.png)

*Figure 2. My Event Details. Your event details will contain a full list of players that pre-registered in the mobile app or on the TCG+ Website. Your focus here will be on the CSV Export and Registration Cutoff.*

From here, when you’re ready to collect registrations, I suggest you cut off the app registrations so that you have one COMPLETED file with all pre-registered players. To cut off the registration, click the button “Registration Cutoff” on the navbar as shown in Figure 2. TCG+ will prompt you to confirm and warn that players will no longer be able to use the app for this event to register. Click “Execute” on that prompt. From here, click on the gray button labeled “CSV Export” and save that file to a place that you will remember. This CSV file is the center of the registration process using this program. 
## Registering Players
Launch the TCG+ Registration helper and using the prompt under File > Open Tournament > Comma-Separated Values File, navigation to the location of where you saved the downloaded CSV file from Bandai TCG+. If all is successful, the program will confirm that tournament has been opened.

![image](https://user-images.githubusercontent.com/1572532/188208806-c1b985ff-a887-4f9c-aaa7-724c4c4d237f.png)

*Figure 3. A loaded tournament in TCG+ Tournament Entry Manager.*

At this point, all you have to do is collect the registration numbers of the players from their Bandai TCG+ app or website as well as their membership names. You can also collect their actual names (optional) and record those as well. (This way if a player does not remember their ID# or membership name, you still have some basis on how to search for them locally if they played in a tournament at your store.) Every player that you add or import, is added to a database saved as an XML file called “AllPlayers.xml” (**DO NOT DELETE THIS FILE**) for reference. At a minimum, to register a player you must enter a TCG+ Membership Number and a TCG+ Membership Name. 

The process of adding a player is fairly simple, type in the number (the leading zeros are not necessary, they will be added by the software), and type in the player’s first and last name (both are optional), then their membership name[^1]. Check the other details (such as assigned first round bye or change status if necessary). When all information is confirmed, simple hit Enter or click “Add Player to Tournament”. Then repeat the process as necessary for the remaining players in the tournament.

If a player pre-registered, via the TCG+ app or website, their name will be listed in the list of players with the status “Successful”. This means the player was successfully pre-registered for the tournament. If you click on that player’s name or type in that player’s number, you can update the status to “Participating in Tournament”. (**Very Important**: Make sure that all players are being added as “Participating in Tournament”. For an explanation on the various statuses, see the section “Tournament Statuses Explained”.) 

For any player who is NOT participating in the tournament but was pre-registered as “Successful”, at this time, you should DROP that player by marking them as “Dropped” or “Absent on Day of Event”. (Again, see the section “Tournament Status Explained”.) You can do this in two ways either: click on the individual row and change the player to Dropped or clicking the checkbox for each player, changing the drop-down menu at the bottom of the window to “Dropped” or “Absent on Day of Event”, then clicking the “Change Checked Entries to:” button.

When you have added the last player to the tournament and are ready to begin the tournament, save the tournament back as a CSV file. (If you click on File > Save > Comma-Separated Values, the program will **OVERWRITE** the current file. If you click on File > Save As > Comma-Separated Values, the program will prompt you on where to save the file. Either version is OK but just make sure that you know where you’re saving the CSV file to.)
## Importing Players
This next step is pretty straight-forward, on the TCG+ Tournament Operations web page for the desired tournament, click CSV Import. Your browser will prompt you for a CSV file. You should import the CSV file that you created in the previous step. If all is well, you will receive a green bar confirming that the CSV Import was successful.
### Troubleshooting
From time to time, the website does act finnicky with regards to uploading players and CSV files. The biggest problem that occurs is the error “Request is conflict”. This error typically occurs when a CSV file contains a player being registered as new but was already pre-registered in the app. Go over the list of pre-registered players on the website and your CSV file and remove any matching players from the CSV file by clicking on the row and hitting DELETE in the corner. 

If a player was added by you, the delete button will simply remove the player from the tournament roll and allow you to resave the file. (Very Important: You MUST resave the file before trying to reupload the CSV file. It normally helps if you also visit another page on the TCG+ page, then navigate back to the desired tournament.) 

If you notice multiple people are double registered, click the check box on that row and hit delete when done. The program will cycle through and delete each player as necessary and if can’t, it will explain why. (**NOTE**: *You CANNOT delete pre-registered players this way*! To remove a pre-registered player who no showed, change the status of that player to “Absent on Day of Event” or “Dropped”.)

Additionally, there are times where the player just outright cannot be added via CSV Import (I do not know why that is, it just happens). At that point, you will have no choice but to add the player as a Guest. See the forthcoming section on how to handle guest registrations.
## Handling Guest Registrations
If a player does not want to participate in TCG+, that is perfectly fine. However, certain events require that in order to receive certain prizing (i.e., invitations) that player must be registered as a TCG+ player. If a player ultimately wishes to not register in TCG+ but wants to participate, you can enroll them as a guest. 

To enroll a player as a guest, on TCG+ proceed to the “Check-In” stage on the navbar (see Figure 4). On this page, you will see four options. Two big blue buttons labeled “QR Code Reader Check In”, “Camera Check-In with QR Code”, “Add Guest”, and “Advance Lottery”. Click on the button “Add Guest” on this page and you will be prompted to enter a username for this player.[^2] It is suggested that this name be unique and not easily confused for another player in the tournament. The player will be added with the number GUEST99999 and the username you chose. This is perfectly normal. This number CANNOT be reused and CANNOT be entered into the software manually. (You CAN import them into the software but the number will not be retained in AllPlayers.xml.)

![image](https://user-images.githubusercontent.com/1572532/188208847-8fe47de1-5087-45e1-84d2-eb3556d8421e.png)
*Figure 4. Day of Check In setup.*

# Running the Actual Tournament
When you are start the actual tournament, click on “Event in Progress” to be taken to the pairings setup screen.

![image](https://user-images.githubusercontent.com/1572532/188208868-47c4f771-907f-4293-b52d-e16ea847bdbb.png)

*Figure 5. The Event in Progress, where you'll be spending 90% of the time processing the event.*

On this screen, you will see all of the players that are active and enrolled in your event. The event is designed to run as a Swiss event by default but you can change this to either Single Elimination (random brackets), Single Elimination (with brackets), or Double Elimination (aka, if you lose twice you are eliminated). You can also change minor details surrounding table numbers and their numbering as well as the sorting of the pairings themselves.[^3]

To make your first-round pairings, click on Create Pairings. If all went well, all players that have been properly enrolled and flagged as participants will be paired up. Click on Confirm Pairings if you are satisfied with the pairings to begin the actual round. (I suggest that you also announce both in person AND via the app that pairings have been posted. To announce the pairings in the app, click on the button “Pairing Push Notification”. TCG+ will confirm if you wish to announce the pairings and when you do, all players who have the TCG+ mobile app installed will be notified that pairings are available to view.) 

![image](https://user-images.githubusercontent.com/1572532/188208896-17824e09-cf45-4562-910d-4aba4576be55.png)
*Figure 6. The pairings and results entry screen. A push notification was sent stating that pairings are available.*

### Collecting Results
To collect results, there are three ways:

- Players submit via their mobile app/website. If the players visit the TCG+ app: My Events > (find the current event) > Check Pairings > Register Results. They can submit the results for the current match. Starting with the player who WON the match, they will submit the results then the loser of the match will then be prompted to confirm. (If both players have the app open at the same time, have the losing player back out to the My Events screen, then once the winner submits, have the loser reenter the “Register Results” screen and confirm.) 

  If the match was a draw, one player will choose the “Draw For Both Players” on the bottom and the other player will confirm. (“Report Time Over” should not be used as this will register a double loss for both players.)
- Players submit their result directly to the scorekeeper. If the player is a guest or if they are having problems with the app, they should report their result either via the result slip or verbally to the scorekeeper. The scorekeeper should ask what table was the match then click on the row for that table, then enter the result as needed. If they need to enter a draw, entering a result of 1-1 will suffice. This will confirm each result as if agreed to by both players using the app.
- Batch results via result slip entry. If using result slips, the scorekeeper should periodically collect the results submitted to them, then click the “Multiple Input” option (found just above the pairings table in the upper right corner of the table) then carefully enter the table number on the result slip, then enter the result as needed. When done, click Store Results Temporarily, then repeat the process for each slip in hand. When done, click “Submit” on the bottom of the window. This will confirm each result as if agreed to by both players using the app.

When all match results are entered and confirmed, click the “Confirm Match Result” button (that should now be enabled when the last match result is entered). Then repeat the process as necessary for each subsequent round. (If you make a mistake and create a round that is not needed, click “Discard Pairings” and confirm.)
## Ending the Tournament
When you are done with the last round of the tournament, click on the button “Event Ended”. (You may need to go back to the Event Details central page. The easier way of doing this is clicking on the event name as found at the top of the page highlighted in blue.) Depending on the configuration of the event, Bandai may wish to collect a questionnaire from the organizer. Answer the questions on the form as needed, then submit. Be sure that the event is fully over before beginning as once you click the button “Event Ended”, it cannot be reopened.

And you are done with the event. You can close out the website or keep it open and repeat the process for other events that are being run simultaneously.
# Special Situations
The following is a list of situations that may come up during the operation of a tournament. It is advised that you read ALL of the instructions to avoid complications later before starting.

Late Entering Player

Per Bandai TCG+, this player would normally have to be enrolled as a guest but this player will then not be able to use the app nor will it count towards the store’s membership numbers. As an alternative, you can also CSV Import that player BUT this will cause a cascading effect of things (and will require a few more involved steps). To enroll late players:

- If the player was pre-registered on TCG+:
  1. Find the player in the list of enrolled players. (Visit the main roster page, where the Applicant List is found. If you’re looking at the pairings screen, scroll up to the top and click on the event name.) Type in either the player’s number or Membership Number as needed in the boxes found on the Applicant List. This will cause the website to filter out the applicants to only the players that match. 
  1. Once found, change the status of this player by clicking the check box and hitting “Allow Tournament Participation”. (Or by clicking the player and then in the next screen, change the status to “Participating in Tournament”. Be sure to save.)
  1. If a player registers TOO late, you may leave them off the pairings and they will receive a match loss for the late entry. I suggest that you perform the above steps in between rounds and import the player then. Otherwise, if you wish to assign them an opponent, you can do so by editing the pairings under “Event in Progress”. (See “Changing The Pairings” later in this section)
- If the player was NOT pre-registered in TCG+.
  1. Create a new BLANK tournament file in the TCG+ Registration Manager. (Very important that this is blank so that you do not accidentally overwrite previously dropped players.)
  1. Add the late player to this blank file as you would normally. Repeat as needed.
  1. CSV Import this NEW file to the website. If all is well, you should have new players in the tournament. 
  1. Pair them as necessary. (See “Changing The Pairings” later in this section)

![image](https://user-images.githubusercontent.com/1572532/188208937-8d37836f-0341-44f5-9ea8-1f15ab7b2ce9.png)

## Changing Match Pairings
From time to time, you may have to fix up the results of a match or the entire pairings list. This is a fragile process and if done incorrectly, may cause more problems down the line. When dealing with modifying the pairings, **BACKUP YOUR CURRENT ROUND**! Print a list of the pairings sheet and keep that on hand when modifying the pairings list.

To modify the pairings list, click on Discard Pairings. TCG+ will prompt that this is irreversible. If ready, confirm that you want to Discard Pairings. You will notice that the only thing on the screen is a list of the players active as of now. If a player was dropped in the current round, they will still be dropped. To readd them, click their name in the user list found at the very bottom of the page and change their status back to “Participating in Tournament”. (Note: If you added late players to the tournament, those players will now be available to assign matches to.) 

For each match, click on the green “Manually Add Pairing” button. In the next screen, you will be prompted to assign the match a table number (if the highest table number is a two-digit or three-digit number, add leading zeroes as necessary. For example: your highest table number is 24. Then table 1 should be entered as Table 01 and so on), then click on the first player, then click on the second player. Then choose to save the pairing. You will notice that the pairing has been made and that the two players are now on the top half of the screen with the assigned table number. Repeat this process for each table as necessary, rebuilding from your print out. 

If you have a player that is now the odd player out, click on that player, assign them the table “BYE”, click on the player’s name, then choose the option “Win by Default” or “Lose by Default” as necessary.  When you are done, click the button Confirm Pairings. 

**IMPORTANT**: If you are doing this because you have added a player late in the middle of an active round, even if the match pairing didn’t change, all players must now refresh their apps in order to report the match result as needed. (Otherwise, they can come up to you as the scorekeeper to enter their match result in. If you fail to mention this, the players will complain that they received an error because of this. This is because the hyperlink to the tournament will be invalid because of the recreation of the pairings.)
## Changing Match Results
Occasionally, the players from time to time may accidentally have entered a match result wrong. There are two ways to fix this:

- Deleting JUST that pairing and allow the players to resubmit. Click on the little cross (×) symbol found at the far-right side of the pairings table for that particular match under the “Discard” column. Click on Manually Add Pairings (that should now be visible) and then readd that match with all details as needed. The players should refresh their apps and they will be able to submit the result.
- Changing the result for them. Find the table of the match result that you need to change. Click on that pairing (anywhere besides the Discard column) and on the subsequent prompt, change the result as needed. This will be considered an admin change and will count as if both players confirmed the result.
## Holding A Lottery For Entries
From time to time, Bandai sets limitations on how many persons can participate in a tournament. This limit cannot be changed at the store level. Where necessary, the store can have an in-house lottery to decide who is playing in the event or not. This process is all handled through the TCG+ website. Steps of which are listed below:

1. Find out what the limit of the event is and determine if you have enough resources (i.e., tournament promos, or booster packs, etc.) to see if you can house more. If you can, simply run the event as normal, declare that all players are “Participating in Tournament” as necessary. Otherwise continue.
1. If you’re going to allow participation based on the check in order at the event, check the entry order for each event. Pre-registered players that have checked in, typically, get priority. Then for everyone else click on the “Advance Lottery” button on the check-in step. The program will then prompt you to enter how many slots should be raffled off. Once you enter the details, the raffle happens and the results are on the screen. All players that were selected will be changed to “Selected + Checked In”. Otherwise, any player who lost the raffle should be updated to “Unsuccessful”. 
## Dropping a Player From The Tournament
If a player wishes to withdraw from the event, this can be done in three ways:

1. Drop the player outright. Find the player from the user list at the bottom of the pairings screen and click on their name. Then change their status to “Dropped”. Be sure to Save.
1. While entering the results of the player’s match. When entering the results of the match, under each player’s win counter there is a box that is labeled “Dropped”. Check the box under the player that you wish to have dropped from the event. (This also applies if you’re using “Multiple Input” to enter player results. (If a player is dropped because of a no-show, the match result is considered to be a 2-0 result in favor of the player who showed up.)
# Recording Tournament Penalties
This program has a feature that will allow you to keep track of penalties issued by staff throughout the tournament. While this information is not immediately available to send to Bandai, it can be helpful to have a central resource so that judges know about a player’s history throughout an event. To use this feature, you must collect membership information of that judge/staff member and add them to the Staff/Judge list as needed.
### Entering Staff Information
Visit the Tournament > Staff/Judges option in the window with a tournament. From here you will be prompted to add in all the judges that are on the staff.

![image](https://user-images.githubusercontent.com/1572532/188209092-ed087cac-6cc0-4e8d-8b20-29a1de58cadd.png)
*Figure 7. The staff list entry screen.*

On this screen, you will be adding each member of the judge team and assigning them a role. If a staff member is not already available to select in the drop-down box of all players, simply click “Add Unlisted” where you will be prompted to add a player name and membership number/name. From there you can assign a position to that staff member. (The program will prompt and warn you if you are trying to add one person to multiple roles or if you’re trying to add a player of the current tournament to your staff.)

The available roles are:

- Tournament Organizer
- Event Manager
- Scorekeeper
- Head Judge
- Assistant Head Judge
- Floor Judge

One you are done entering all staff members, the Penalties screen is now open as option. (You must have at least one staff member before you add penalty details.)
### Recording Penalty Details
Once you have added at least one staff to the staff roster, you can now add in penalty details. To start, with an open tournament, visit Tournament > Penalties. 

![image](https://user-images.githubusercontent.com/1572532/188209107-75cb21d3-e102-4bba-9e49-14e602371647.png)
*Figure 8. The List of Penalties screen.*

To add a penalty, click on add penalty and you provided the details as necessary. When done, click “OK”.

![image](https://user-images.githubusercontent.com/1572532/188209124-09d7bb5c-1302-4e94-8ebf-c60d53fced0e.png)

The Player drop-down list only has the list of players that are registered in the current open tournament file. If a spectator committed a fault, register that player, and then provided the details as necessary.

Note in order to save these details, you must save this tournament not just as a CSV but also as an XML file. The XML file contains full details about the tournament including the staff and penalty lists. If using these advanced features, **YOU MUST SAVE THIS FILE AS AN XML** in order to retain the penalty and staff listing.
# CSV File Schema
If you’re also inclined, you can make your own CSV file without the need for a program like this. You’ll just need to be aware of the fields and their definitions.

Team ID, Team Name, Win Point, Status, Bye Count, Membership Number - 1, Player Name - 1, Seat Order - 1, Memo

- The **Team ID** should be a zero unless you are pulling the CSV from Bandai TCG+. (DO NOT ARBITRARILY SET A NUMBER HERE. Either it’s ZERO or a number TCG+ gave you.)
- **Team Name** should be the name of the entrant team. (Not used in single events.)
- **Win Point** is the total number of Swiss points. This column is typically ignored by TCG+ on imports and shouldn’t be set to anything but zero when importing new players.
- **Status** is the current status of the player. This field must be set using the tournament status code found in the “Tournament Status” section. 
- **Bye Count** should either be a one if there is a first-round bye or zero otherwise.
- **Membership Number** **- 1** should be the full, zero leading, 10-digit membership number for the player. This CANNOT be GUEST99999 unless Team ID is a non-zero assigned by Bandai TCG+ (aka you’re reimporting players). (THIS FIELD CANNOT BE BLANK. If you are trying to register a guest player, you MUST use the TCG+ webpage.)
- **Player Name - 1** refers to the membership handle belonging to the player. (Not their actual name. HINT: You do not need to exactly match this with the registered Player Name. TCG+ will handle that for you.)
- **Seat Order - 1** refers to the seat letter assigned to the player. (Mostly for multiplayer matches.) This is required to be set for ALL EVENTS. In the case of a solo player event, this becomes “A” for all players.
- **Memo** is a note field for each individual player. In this program, it will input the players name (last name, first name) when the program saves the CSV file.

When making this CSV file, be sure that all fields (yes, ALL fields) are encased with double quotation marks around the data fields. Each record should appear on its own line with a comma between each field. Also, the first row of the CSV data file MUST be the list of fields as shown above. If you’re using a program like Excel or LibreOffice, when entering the player numbers, it may help to type a single quotation mark (‘) before entering the zeroes. 
# Appendices
## Tournament Status

|**Code**|**Status**|**Definition**|
| :- | :- | :- |
|1|Applied|Player has applied for the event but was not accepted.|
|2|Successful|The player has applied for the event and is eligible for the tournament|
|3|Waiting List|The player has applied for the event but the number of players exceed the capacity. They are on the waiting list for the event|
|4|Unsuccessful|This player attempted to enter the event but was unsuccessful due to event limits.|
|5|Cancelled|This event was cancelled and thus the player registration was cancelled.|
|6|Selected + Checked In|This player was selected via the lottery and has checked in.|
|7|Waiting for Cancellation + Checked In|This event was cancelled and this player is waiting to be cancelled.|
|8|Absent on Day of Event|This player pre-registered but was not present at the event on the day of the event. This player will be left off the pairings.|
|9|Advance Elected|Not presently used. |
|10|Participating in Tournament|This player is a fully enrolled tournament player and is active in the tournament.|
|11|Dropped|This player was a fully enrolled tournament player but has elected to withdraw and be dropped from the event.|

# Program Version History
Version 1.0 / September 1, 2022:

- Initial release of software. 
# Acknowledgements / Thank You
*This program was created independently from Bandai and Bandai TCG+. It is a program that can be used to create a set of data files to add in the operation of tournaments for Bandai TCG+ such as Digimon, Dragon Ball Super, and One Piece. This project was made independently of them and they have nothing to do with its development and upkeep.*

![image](https://user-images.githubusercontent.com/1572532/188209181-8d8085fc-de24-40fa-9e1e-e55ec63d9b1c.png)

*While this is software is provided for free, if you wish to provide a gratuity for the person who made it, you can do so here: <https://ko-fi.com/retched>*
# License
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

[^1]: It is preferred that the membership name of the player be EXACTLY as it is on the app. But it does not have to be. In fact, this field is typically optional as TCG+ will retrieve the actual name.
[^2]: Any player registered this way cannot be changed into a TCG+ registered player later in the tournament. Only use this option as a last resort of adding a player to your tournament. Additionally, any player registered as a guest cannot use the Bandai TCG+ app and website for match and result reporting.
[^3]: For more explanation on these features, I recommend you watch the Bandai TCG+ tutorial over Zoom.
