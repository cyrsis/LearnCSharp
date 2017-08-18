//This code is based on a blog post from Mark Heath
// http://mark-dot-net.blogspot.com/2009/10/playback-of-sine-wave-in-naudio.html

using System;
public class SineWaveProvider32 : WaveProvider32
{
    int sample;

    public SineWaveProvider32()
    {
        Frequency = 440;
        Amplitude = 0.25f; // let's not hurt our ears            
    }

    public float Frequency { get; set; }
    public float Amplitude { get; set; }

    public override int Read(float[] buffer, int offset, int sampleCount)
    {
        int sampleRate = WaveFormat.SampleRate;
        for (int n = 0; n < sampleCount; n++)
        {
            buffer[n + offset] = (float)(Amplitude * Math.Sin((2 * Math.PI * sample * Frequency) / sampleRate));
            sample++;
            if (sample >= sampleRate) sample = 0;
        }
        return sampleCount;
    }
}