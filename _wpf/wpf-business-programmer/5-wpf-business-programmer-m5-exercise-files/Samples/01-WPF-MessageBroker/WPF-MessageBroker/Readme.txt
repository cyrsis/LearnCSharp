WPF Message Broker Sample
--------------------------------
This sample illustrates how to use the PDSA Message Broker system

The message broker helps you communicate within a WPF application by using a messaging system. This method will reduce the coupling between user controls, windows and view models by using an event system.

The Message Broker is created at the application level and each window, user control and view model can use this "global" setting to communicate back and forth.

NOTE: Make sure you always remove your event handlers prior to your control being unloaded, or prior to losing access to a View Model.
