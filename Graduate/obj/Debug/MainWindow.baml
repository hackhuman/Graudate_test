   M S B A M L   `   `   `  ����C  ?Graduate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GraduateGraduate  5   	       Graduate.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Graduate     5   	     � Title$  登录��5   	   $	��450��6   $	��800��6!   $y�Visible=�6-    � 
ResizeMode$ NoResize=�6B    � WindowStartupLocation$ CenterScreen=�6X   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��344* �6   �� 5      $
��451* �6   ��5   
   �� 5       �� ImageSource$ background.jpg��6    j� Stretch$
 None=�66   .+�5   
   �� -   5         ��Name$ Button_Login��5      $��登录��6'   $
��Left=�64   $��239,258,0,0q�6O   $	��Top=�6d   $��84��6|   $��34��6�   6�   �� 5   
   -   5        $ Button_Cancel��5      $��取消��6(   $
��Left=�65   $��133.5,258,0,0q�6P   $	��Top=�6g   $��84��6    J� RenderTransformOrigin$ -0.445,0.378&�6�   $��34��6�   $��1��6�   �� 5   
   -   5         ��Name$ TexBox_Account��5      $
��Left=�6*   $��36��6E   $��
239,84,0,0q�6Q   	 �� TextWrapping$
	 Wrap=�6e   $	��Top=�6y   $	��322��6�   $��20(�6�   $��2��6�   �� 5   
   -   5        $ TextBox_Password��5      $
��Left=�6,   $��35��6G   $��239,169,0,0q�6S   $
	 Wrap=�6h   $	��Top=�6|   $	��322��6�   $��20(�6�   $��2��6�   �� 5   
   -   5        
 ��Name$
 Label_Account��5      $��账号��6'   $
��Left=�64   $��
150,82,0,0q�6O   $	��Top=�6c   $��38��6{   $��20(�6�   $��84��6�   �� 5   
   -   5        $
 Label_Password��5      $��密码��6(   $
��Left=�65   $��150,169,0,0q�6P   $	��Top=�6e   $��68��6}   $��20(�6�   5      5      