/*
 * Steps to include a WAV audio file:
 * 0. Find and download a WAV file that you can use legally.
 * 1. From the toolbar, Project => Add Existing Item... => Pick the .wav audio file
 * 2. Same as with data files, set the .wav file to "Copy if newer" so that the file is included in your build.
 * 
 * Some places to find free music/sounds that you can use legally:
 * - https://incompetech.com/
 * - https://freesound.org/
 * - https://www.youtube.com/audiolibrary/music?nv=1
 * - https://freemusicarchive.org/
 * - https://jfxr.frozenfractal.com/
 */

using System;
using static System.Console;

// Bring in the namespace that contains the SoundPlayer class.
using System.Media;

namespace PlayAudio
{
    class Program
    {
        static void Main(string[] args)
        {
            // See the docs: https://docs.microsoft.com/en-us/dotnet/api/system.media.soundplayer?view=netframework-4.8.
            // ONLY WAV ARE FILES SUPPORTED!
            SoundPlayer spookyPlayer = new SoundPlayer("Fun_House.wav");
            spookyPlayer.Load();
            //spookyPlayer.Play();
            spookyPlayer.PlayLooping();

            // Note: the SoundPlayer class can only only play one sound at a time. So, you can use
            // it either for background ambience/music or for sound effects, but you can't use it to
            // play both spooky music and trigger sound effects simultaneously!

            ForegroundColor = ConsoleColor.White;
            WriteLine(@"
                                              ,           ^'^  _
                                              )               (_) ^'^
         _/\_                    .---------. ((        ^'^
         (('>                    )`'`'`'`'`( ||                 ^'^
    _    /^|                    /`'`'`'`'`'`\||           ^'^
    =>--/__|m---               /`'`'`'`'`'`'`\|
         ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                     .-------.`|`````````````|`  .   )
                    / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                   /  |_| |_|  \  |__| |__|  | /,-,\||
        _         /_____________\ |')| |  |  |/ |_| \|
       (')         |  __   __  |  '==' '=='  /_______\     _
      (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
       \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
     _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
   ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb


== Credits ==
Music: 'Fun House' by Coyote Hearing from youtube.com/audiolibrary
Art: Haunted house by ldb from https://www.asciiart.eu/holiday-and-events/halloween
");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n(Press any key to exit)");
            ReadKey();
        }
    }
}
