using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.Events;
public interface IEventInfo
{
}

public class EventInfo : IEventInfo
{
    public UnityAction Actions;

    public EventInfo(UnityAction action)
    {
        Actions += action;
    }
}

public class EventInfo<T> : IEventInfo
{
    public UnityAction<T> Actions;

    // 泛型类构造函数不需要带尖括号<>
    public EventInfo(UnityAction<T> action)
    {
        Actions += action;
    }
}
public class EventInfoInparams : IEventInfo
{
    public UnityAction<object[]> Actions;

    public EventInfoInparams(UnityAction<object[]> action)
    {
        Actions += action;
    }

    // 新的重载构造函数，支持多种形式
    public EventInfoInparams(params UnityAction<object[]>[] actions)
    {
        foreach (var action in actions)
        {
            Actions += action;
        }
    }
}
public class MyEventManager
{
    private static MyEventManager _instance;
    
    public static MyEventManager Instance => _instance ??= new MyEventManager();

    protected readonly Dictionary<string, IEventInfo> EventDic;
    
    protected MyEventManager()
    {
        EventDic = new Dictionary<string, IEventInfo>();
    }

    // 添加事件监听
    public void AddEventListener(string eventName, UnityAction action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo).Actions += action;
        }
        else
        {
            EventDic.Add(eventName, new EventInfo(action));
        }
    }

    // 删除事件监听
    public void RemoveEventListener(string eventName, UnityAction action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo).Actions -= action;
        }
    }

    // 事件触发器
    public void EventTrigger(string eventName)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo).Actions?.Invoke();
        }
    }

    public void AddEventListener<T>(string eventName, UnityAction<T> action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo<T>).Actions += action;
        }
        else
        {
            EventDic.Add(eventName, new EventInfo<T>(action));
        }
    }

    public void RemoveEventListener<T>(string eventName, UnityAction<T> action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo<T>).Actions -= action;
        }
    }

    public void EventTrigger<T>(string eventName, T info)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfo<T>).Actions?.Invoke(info);
        }
    }

    #region 多个参数试做,用装箱拆箱来实现
    public void AddEventListener(string eventName, UnityAction<object[]> action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfoInparams).Actions += action;
        }
        else
        {
            EventDic.Add(eventName, new EventInfoInparams(action));
        }
    }

    public void RemoveEventListener(string eventName, UnityAction<object[]> action)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfoInparams).Actions -= action;
        }
    }
    

    public void EventTrigger(string eventName, params object[] info)
    {
        if (EventDic.ContainsKey(eventName))
        {
            (EventDic[eventName] as EventInfoInparams).Actions?.Invoke(info);
        }
    }
    #endregion

    // 清除所有事件
    public virtual void ClearAllEvent()
    {
        EventDic.Clear();
    }
}

