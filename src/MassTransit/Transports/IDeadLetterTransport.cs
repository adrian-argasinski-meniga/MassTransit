﻿// Copyright 2007-2018 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
namespace MassTransit.Transports
{
    using System.Threading.Tasks;


    /// <summary>
    /// If present, can be used to move the <see cref="ReceiveContext"/> to the dead letter queue
    /// </summary>
    public interface IDeadLetterTransport
    {
        /// <summary>
        /// Writes the message to the dead letter queue, adding the reason as a transport header
        /// </summary>
        /// <param name="context"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        Task Send(ReceiveContext context, string reason);
    }
}