using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActivityTimer
{
    class SoundPlayer
    {
        private System.Media.SoundPlayer soundPlayer = null;
        private bool isSoundPlayerLoaded = false;
        Thread systemSoundThread = null;
        ManualResetEvent systemSoundStopper = new ManualResetEvent (true);

        public SoundPlayer ()
        {
            isSoundPlayerLoaded = false;
            systemSoundThread = new Thread (SystemSoundThreadAutomaticLoop);
        }
        public SoundPlayer (string pathToFile)
        {
            try
            {
                soundPlayer = new System.Media.SoundPlayer (pathToFile);
                soundPlayer.Load ();
                isSoundPlayerLoaded = true;
            }
            catch (Exception /*e*/)
            {
                isSoundPlayerLoaded = false;
                systemSoundThread   = new Thread (SystemSoundThreadAutomaticLoop);
            }
        }

        public void PlaySoundUntilStop ()
        {
            if (isSoundPlayerLoaded)
            {
                soundPlayer.PlayLooping ();
            }
            else
            {
                systemSoundThread.Start ();
                systemSoundStopper.Set ();
            }
        }

        public void StopSound ()
        {
            if (isSoundPlayerLoaded)
            {
                soundPlayer.Stop ();
            }
            else
            {
                systemSoundStopper.Reset ();
            }
        }

        private void SystemSoundThreadAutomaticLoop ()
        {
            while (systemSoundStopper.WaitOne ())
            {
                System.Media.SystemSounds.Beep.Play ();
                Thread.Sleep (1000);
            }
        }
    }
}
