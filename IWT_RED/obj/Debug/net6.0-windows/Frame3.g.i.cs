﻿#pragma checksum "..\..\..\Frame3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CE51F039B3A232F0E9DF10457D340E5CFB8514E6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IWT_RED;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace IWT_RED {
    
    
    /// <summary>
    /// Frame3
    /// </summary>
    public partial class Frame3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Frame3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Frame3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB4;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Frame3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB5;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Frame3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB6;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/IWT_RED;component/frame3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Frame3.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            
            #line 12 "..\..\..\Frame3.xaml"
            this.Grid.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.keyDown));
            
            #line default
            #line hidden
            return;
            case 2:
            this.TB4 = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\Frame3.xaml"
            this.TB4.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TB5 = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\Frame3.xaml"
            this.TB5.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged2);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TB6 = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\Frame3.xaml"
            this.TB6.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged3);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 64 "..\..\..\Frame3.xaml"
            ((System.Windows.Controls.Border)(target)).AddHandler(System.Windows.Input.Mouse.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.AcceptFrame3));
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 68 "..\..\..\Frame3.xaml"
            ((System.Windows.Controls.TextBlock)(target)).AddHandler(System.Windows.Input.Mouse.MouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.GetCodeAgane));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

