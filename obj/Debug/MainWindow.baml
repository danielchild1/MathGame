   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MathGameMathGame  5   	       MathGame.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MathGame     5   	   -   5          �Name$  Mathketball��5   	    � Title$ Math-ketball��5   	   $��344.581��6   $��538.917��6/    � 
ResizeMode$ NoResize=�6?   .��5	      � ��5
   
   �� 5       �� ImageSource$' !istockphoto-165806666-612x612.jpg��6    � ColumnDefinitions 5   
   �� 5      $
��563* �6   �� 5      $
��229* �6   .+�5   
   �� -   5         ��Name$ 
TbuserName��5      $
��Left=�6&   $��23��6A   $��
108,55,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Tom��6u   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ label��5      $��Math-ketBall��6   $
��Left=�66   $��
195,19,0,0q�6Q   $	��Top=�6e   $	��159��6}   $
��Bold"�6�   $��Rockwell)�6�   $��18(�6�   �� 5   
   -   5        $ label1��5      $��Name:��6    $
��Left=�60   $��	24,55,0,0q�6K   $	��Top=�6^   $��63��6v   $
��Bold"�6�   �� 5   
   -   5        $ label2��5      $
��Age:��6    $
��Left=�6/   $��
294,55,0,0q�6J   $	��Top=�6^    J� RenderTransformOrigin$ 0.193,-0.015&�6v   $
��Bold"�6�   �� 5   
   -   5        $ TbAge��5      $
��Left=�6!   $��23��6<   $��
354,55,0,0q�6H   $
 Wrap=�6\   $��5��6p   $	��Top=�6y   $��35��6�   $��2��6�   	� 5   
   -   5        	 	�Name$	 
RbAddition��5      $��Addition��6*   $
��Left=�6=   $��	46,96,0,0q�6X   $	��Top=�6k   $
��Bold"�6�   
 d� 	IsChecked$
 FalseY�6�   	� 5   
   -   5        $	 RbSubtraction��5      $��Subtraction��6-   $
��Left=�6C   $��
145,96,0,0q�6^   $	��Top=�6r   $
��Bold"�6�   6�   	� 5   
   -	   5        $	 RbMultiplication��5      $��Multiplication��60   $
��Left=�6I   $��
253,96,0,0q�6d   $	��Top=�6x   $
��Bold"�6�   6�   	� 5   
   -
   5        $	 
RbDivision��5      $��Division��6*   $
��Left=�6=   $��	10,96,0,0q�6X   $	��Top=�6k   $��1��6�   $
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ BtStartGame��5      $��
Start Game��6&   $
��Left=�6;   $��145,210,0,0q�6V   $	��Top=�6k   $	��244��6�   $��43��6�   $��2��6�   6�   �� 5   
   -   5        $ LbError��5      $��Please Enter Valid Age��6!   $
��Left=�6B   $��145,258,0,0q�6]   $	��Top=�6r   $	��282��6�   
���  ��$��18(�6�   $
��Bold"�6�   $��2��6�   5      5      