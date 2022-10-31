using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class MyScheduler : MonoSingleton<MyScheduler>
{
    //private ulong _currentFrame = 0;
    private List<ulong> _currentFrames = new List<ulong>();
    private List<Scheduler> _schedules = new List<Scheduler>();

    public void Update()
    {
        //_currentFrame++;
        //foreach (var _schedule in _schedules)
        //{
        //    _schedule.CheckCall(_currentFrame);
        //}

        Debug.Log(_currentFrames.Count);

        for (int i = 0; i < _schedules.Count; i++)
        {
            _schedules[i].CheckCall(_currentFrames[i]);
            _currentFrames[i]++;
        }
    }

    public void AddSchedule(int _frame, Action _action)
    {
        if (_frame <= 0)
        {
            Debug.Log("frame이 0보다 작거나 같아서 return");
            return;
        }

        if (_action == null)
        {
            Debug.Log("action이 비었으니 return");
            return;
        }

        foreach (var item in _schedules)
        {
            if (item.Frame == _frame || item.Call == _action)
            {
                Debug.Log("이미 들어있음");
                return;
            }
        }

        _currentFrames.Add(0);

        // 생성자
        _schedules.Add(new Scheduler()
        {
            Frame = _frame,
            Call = _action,
        });
    }

    public void RemoveSchedule(Action _action)
    {
        foreach (var item in _schedules)
        {
            if (item.Call == _action)
            {
                var target = _schedules.IndexOf(item);
                _schedules.Remove(item);
                _currentFrames.RemoveAt(target);
                break;
            }
        }
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