﻿using System;
using System.ComponentModel;

namespace GraphLabs.Common.UserActionsRegistrator
{
    /// <summary> Сервис регистрации действий клиента </summary>
    public interface IUserActionsRegistratorClient
    {
        /// <summary> Регистрация действий завершена </summary>
        event EventHandler<RegisterUserActionsCompletedEventArgs> RegisterUserActionsCompleted;

        /// <summary> Зарегистрировать действия </summary>
        void RegisterUserActionsAsync(long taskId, Guid sessionGuid, ActionDescription[] actions, bool isTaskFinished);

        /// <summary> Подключение закрыто </summary>
        event EventHandler<AsyncCompletedEventArgs> CloseCompleted;

        /// <summary> Закрыть подключение </summary>
        void CloseAsync();
    }

    /// <summary> Сервис регистрации действий клиента </summary>
    public partial class UserActionsRegistratorClient : IUserActionsRegistratorClient
    {
    }
}
    