mvvm
====

Model View View-Model with a background worker updating model properties.

This project provides an MVVM solution where updates that are performed on the Model are propagated through the View Model to the View.

This simulates a system where a GUI View is updated when a Model object is modified by an external source.

The MVVM classes are:

Model - Foo
View Model - FooViewModel
View - FooView

The simulator that updates the Foo model is named DataUpdater.

To propagate update notifications, the WPF IPropertyChanged interface is used in the Model and the ViewModel layers.

To subscribe to property changes from the Model, the ViewModel adds a handler for the PropertyChanged event.  The View subscribes by using hte UpdateSourceTrigger XAML markup.
