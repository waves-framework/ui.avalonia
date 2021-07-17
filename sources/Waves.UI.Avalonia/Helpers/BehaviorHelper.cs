﻿// using Avalonia;
//
// namespace Waves.UI.Avalonia.Helpers
// {
//     /// <summary>
//     /// Behavior helper.
//     /// </summary>
//     public static class BehaviorHelper
//     {
//         /// <summary>
//         /// Gets or sets Behaviors property.
//         /// </summary>
//         public static readonly StyledProperty<BehaviorCreatorCollection> BehaviorsProperty =
//             AvaloniaProperty.Register(
//                 "Behaviors",
//                 typeof(BehaviorCreatorCollection),
//                 typeof(BehaviorHelper),
//                 new UIPropertyMetadata(null, OnBehaviorsChanged));
//
//         /// <summary>
//         /// Gets behavior collection from tree view.
//         /// </summary>
//         /// <param name="treeView">Tree View.</param>
//         /// <returns>Behavior collection.</returns>
//         public static BehaviorCreatorCollection GetBehaviors(TreeView treeView)
//         {
//             return (BehaviorCreatorCollection)treeView.GetValue(BehaviorsProperty);
//         }
//
//         /// <summary>
//         /// Sets behavior collection to tree view.
//         /// </summary>
//         /// <param name="treeView">Tree View.</param>
//         /// <param name="value">Behavior collection.</param>
//         public static void SetBehaviors(TreeView treeView, BehaviorCreatorCollection value)
//         {
//             treeView.SetValue(BehaviorsProperty, value);
//         }
//
//         /// <summary>
//         /// Actions when behaviors changed.
//         /// </summary>
//         /// <param name="dependencyObject">Dependency object.</param>
//         /// <param name="e">Arguments.</param>
//         private static void OnBehaviorsChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
//         {
//             if (e.NewValue is BehaviorCreatorCollection == false)
//             {
//                 return;
//             }
//
//             if (!(e.NewValue is BehaviorCreatorCollection newBehaviorCollection))
//             {
//                 return;
//             }
//
//             var behaviorCollection = Interaction.GetBehaviors(dependencyObject);
//             behaviorCollection.Clear();
//
//             foreach (var behavior in newBehaviorCollection)
//             {
//                 behaviorCollection.Add(behavior.Create());
//             }
//         }
//     }
// }
