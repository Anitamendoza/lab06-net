   M S B A M L   `   `   `  ����?  ;Lab5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab5Lab5  5   	       Lab5.ListarEmpleados   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab5     5   	     � Title$  Listar Empleados��5   	   $	��600��6"   $	��800��6/   ���#D8BFD8.��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��	Empleados��6!   $��24(�62   $
��Bold"�6@   $��0,0,0,10q�6R   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridEmpleados��5      $��1��6.      AutoGenerateColumns .  $��0,10,0,0q�6W   $��Stretch=�6i   
����������#333333   GridLinesVisibility$ 
Horizontal=�6�      AlternatingRowBackground �#F5F5F5   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
IdEmpleado��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6X   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *
IdEmpleado+6X     5      $ 	Apellidos��6%   $	 150 6V   	 68   �� *	Apellidos+6V     5      $ Nombre��6%   $	 150 6P   	 65   �� *Nombre+6P     5      $ Cargo��6%   	 64   �� *cargo+  5      $ Tratamiento��6%   $	 150 6Z   	 6:   �� *Tratamiento+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 200 6)   
   CellTemplate
 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� -   5        $��
Actualizar��5   )   $	��150��6Z   $
��Bold"�6f   $��16(�6x   ���#800080
�������$��0,0,10,0q�6�   �� 5!   "   -   5        $��Eliminar��5!   )   
 � Tag$ Eliminar��6X   $	��150��6g   $
��Bold"�6s   $��16(�6�   ���#800080
�������$��0,0,10,0q�6�   5$      5'      5)      5+      5,      5-      