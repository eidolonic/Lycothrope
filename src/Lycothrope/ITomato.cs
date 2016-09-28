﻿namespace Lycothrope
{
    public enum TomatoState
    {
        Started, Stopped, Completed
    }

    public enum Cultivar
    {
        Pomodoro, ShortBreak, LongBreak
    }

    public interface ITomato
    {
        Cultivar Cultivar();
        int Lifespan();
    }
}

