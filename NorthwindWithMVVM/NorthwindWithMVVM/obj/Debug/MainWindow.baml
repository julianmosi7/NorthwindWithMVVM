   M S B A M L   `   `   `  ����L  HNorthwindWithMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:NorthwindWithMVVMNorthwindWithMVVM  5   	   L HOrderViewModelLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:OrderViewModelLib;assembly=OrderViewModelLibOrderViewModelLib 5   	   "    NorthwindWithMVVM.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:NorthwindWithMVVM     5   	   Xorderviewmodellib:clr-namespace:OrderViewModelLib;assembly=OrderViewModelLib     5   	   X TXceed.Wpf.Toolkit, Version=3.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   -   5          � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � DataContext 5      &   OrderViewModelLib.OrderViewModel  5   
   .��5      � .+�5   
   �� $��Min.Date��6   $
��Left=�6#   $��	30,42,0,0q�6>   $	��Top=�6Q   �� 5   
   $
��Left=�6   $	��194��6-   $��
30,161,0,0q�6:   $	��Top=�6N   $	��276��6f   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5      ��5      �� *Orders+ �� SelectedItem 5      �� *SelectedOrder+ �� Mode$ TwoWay=��� 5   
   $
��Left=�6   $	��100��6-   $��403,161,0,0q�6:   $	��Top=�6O   $	��362��6g   $
 TrueY�5      ��5      �� *OrderDetails+ 5      �� *SelectedOrderDetail+$ TwoWay=��� 5   
   $
��Left=�6   $��403,282,0,0q�6.   $	��Top=�6C   $	��270��6[   ��5      �� *AllProducts+ 5      �� *SelectedProduct+$ TwoWay=��� 5   
   $	��Add��6   $
��Left=�6   $��690,282,0,0q�6:   $	��Top=�6O   $��75��6g   ��6r   �� *
AddCommand+$ OneWay=��� 5   
   $��Quantity��6   $
��Left=�6#   $��403,329,0,0q�6>   $	��Top=�6S   �� 5    
   $��Productname:��6   $
��Left=�6'   $��
548,42,0,0q�6B   $	��Top=�6V   �� 5!   
   $��	Supplier:��6   $
��Left=�6$   $��
548,73,0,0q�6?   $	��Top=�6S   �� 5"   
   $
��Left=�6   $��23��6-   $��
636,42,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *Productname+$ TwoWay=�6�   �� 5#   
   $
��Left=�6   $��23��6-   $��
636,76,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��120��6�   ��6a   �� *Suppliername+$ TwoWay=�6�   &   Xceed.Wpf.Toolkit.DateTimeUpDown  5$   
   $
��Left=�6   $��	93,45,0,0q�69   $	��Top=�6L   $	��213��6d   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6p   �� *	MinDate+ 6�   �� $ OneWay=� �� StringFormat$ {0:M:yy}��#  Xceed.Wpf.Toolkit.ShortUpDown  5%   
   $
��Left=�6   $��464,335,0,0q�66   $	��Top=�6K   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 6c   �� *
Quantity+$ TwoWay=��� 5&   
   $
��Left=�6   $��403,130,0,0q�6+   $	��Top=�6@   $��88��6X    6c   �� *SelectedOrderDate+$ OneWay=�5'      5(      