﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █      ▄████████                                        ▄████████
      █     ███    ███                                        ███    ███
      █     ███    █▀   █    █     ▄█████ ██▄▄▄▄      ██      ███    ███     ██        ██       █████  █  ▀██████▄  ██   █      ██       ▄█████
      █    ▄███▄▄▄     ██    ██   ██   █  ██▀▀▀█▄ ▀███████▄   ███    ███ ▀███████▄ ▀███████▄   ██  ██ ██    ██   ██ ██   ██ ▀███████▄   ██   █
      █   ▀▀███▀▀▀     ██    ██  ▄██▄▄    ██   ██     ██  ▀ ▀███████████     ██  ▀     ██  ▀  ▄██▄▄█▀ ██▌  ▄██▄▄█▀  ██   ██     ██  ▀  ▄██▄▄
      █     ███    █▄  ██    ██ ▀▀██▀▀    ██   ██     ██      ███    ███     ██        ██    ▀███████ ██  ▀▀██▀▀█▄  ██   ██     ██    ▀▀██▀▀
      █     ███    ███  █▄  ▄█    ██   █  ██   ██     ██      ███    ███     ██        ██      ██  ██ ██    ██   ██ ██   ██     ██      ██   █
      █     ██████████   ▀██▀     ███████  █   █     ▄██▀     ███    █▀     ▄██▀      ▄██▀     ██  ██ █   ▄██████▀  ██████     ▄██▀     ███████
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System;

namespace Symbiote.SDK.Event
{
    /// <summary>
    ///     Creates the Event attribute for system Events.
    /// </summary>
    [AttributeUsage(AttributeTargets.Event)]
    public class EventAttribute : Attribute
    {
        /// <summary>
        ///     Gets or sets the Event description.
        /// </summary>
        public string Description { get; set; }
    }
}