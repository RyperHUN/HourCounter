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
                PlayRandomWindowsSound ();
                Thread.Sleep (1000);
            }
        }

        private void PlayRandomWindowsSound ()
        {
            int num = new Random ().Next (4);
            switch (num)
            {
                case 0:
                    System.Media.SystemSounds.Asterisk.Play();
                    break;
                case 1:
                    System.Media.SystemSounds.Beep.Play();
                    break;
                case 2:
                    System.Media.SystemSounds.Exclamation.Play();
                    break;
                case 3:
                    System.Media.SystemSounds.Hand.Play();
                    break;
            }
        }
    }
}
