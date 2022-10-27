using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScheduler : MonoSingleton<MyScheduler>
{
    private ulong _currentFrame = 0;

    private List<Scheduler> _schedules = new List<Scheduler>();

    public void Update()
    {
        _currentFrame++;

        foreach (var _schedule in _schedules)
        {
            _schedule.CheckCall(_currentFrame);
        }
    }

    public void AddSchedule(int _frame, Action _action)
    {
        if (_frame <= 0)
        {

        }

        if (_action == null)
        {

        }

        // »ý¼ºÀÚ
        _schedules.Add(new Scheduler()
        {
            Frame = _frame,
            Call = _action,
        });
    }

    public void RemoveSchedule(Action _action)
    {

    }

    private class Scheduler
    {
        public int Frame;
        public Action Call;

        public void CheckCall(ulong _frame)
        {
            if (_frame % (ulong)Frame == 0)
            {
                Call?.Invoke();
            }
        }
    }
}