using System;
using UnityEngine;

// TODO: Resolve all data types used. I've hucked in whatever seemed appropriate from a cursory glance

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

    // Event_type includes arrival, harvest, process, finish 
    // Event is defined as a point on the timeline.
    class Event 
    {
        Event();
        Event(string name, string? e_type, string? e_happen_time, string? place, Machine machine, Operator operator, Job job);
        string[] getEventInfo();
    }

    class Job 
    {
        Job();
        Job(string? name, string? place, string? state);
        void startRework(int this_clock);
        void enterSys(int this_clock);
        void leaveSys(int this_clock);
        void booked();
    }

    class Machine 
    {
        Machine();
        Machine(string? name, string? m_type);
        void startSetup(Job job, Operator operator);
        void endSetup();
        void startWork();
        void endWork();
        void booked();
    }
    class Queue 
    {
        Queue();
        Queue(string? name, string? q_type);
        void addJob(Job job);
        void removeJob(Job job);
    }

    class Operator 
    {
        Operator();
        Operator(string? name, string? o_type);
        void booked();
    }
    
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