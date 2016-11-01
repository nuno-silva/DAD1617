﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonExceptions
{
    public class AlreadyRegisteredException : Exception
    {
        public AlreadyRegisteredException() : base("Client already registered")
        {

        }


    }
}
namespace CommandExceptions
{
    public class UnaccessibleClientException : Exception
    {
        public UnaccessibleClientException(string clientName) : base("Client " + clientName + " is unaccessible!")
        {

        }
    }

    public class WrongCommandFormat : Exception
    {
        public WrongCommandFormat(string commandName) : base("Format for  " + commandName + " is is invalid!")
        {

        }
    }

    public class UnexistentCommand : Exception
    {
        public UnexistentCommand(string commandName) : base("Command " + commandName + " doesn't exist!")
        {

        }
    }

}
