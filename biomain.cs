using System;
using UnityEngine;

namespace BioManFactory 
{
    class MainRunner 
    {
        void putSomethingIntoCSV(string? something, string fname);
        double truncatedNormGen(double lower, double mu, double sigma);
        int translateIntoDesign(string item);

        static void Main(string[] args) 
        {
            /// INSERT A BUNCH OF CODE AT THE BOTTOM OF BM_Factory.py
        }
    }

    class Event {}
    class Job {}
    class Machine {}
    class Queue {}
    class Operator {}
    class Design {} // Need to figure out what this design majig is

    class Environment 
    {
        Environment();
        Environment(int[] design, int group_num);

        void MachineAndOperatorSetup();
        Event getEvent();
        void addEvent(Event event);
        int[] getCurrentState();
        string[] getReworkState();
        Design Simulate();
        Job jobGenerator(string name, string place, string state);
        double processingYieldCurrve(int dura, Job job);
        void operatorLookForMyNextJobInOprQueue(Operator operator);
        void machineLookForMyNextJobInQueue(Machine machine);
        Operator[] getAvailableOperator(string operator_type);
        Machine[] getAvailableMachine(string machine_type);
        void processEvent(Event this_event);
        string highFidelityTestCaseA();
        string highFidelityTestCaseB();
        string lowFidelityTestCaseA();
        string lowFidelityTestCaseB();
        string qualityPolicy(int QM_policy_MFG, Job job);
    }
}