   M S B A M L   `   `   `  ����E  AProjectCmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ProjectCmo
ProjectCmo  5          ProjectCmo.CardControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:ProjectCmo     5      -   5        $��UserControl��5   %   $	��154��6   $	��100��6     � 	Resources  5	      "   ProjectCmo.RankNameConverter   rankConverter  SuitTemplate �� 
TargetType  	SuitImage �� Triggers �� Binding �� ElementName �� Path �� Value �� Property �� Value��%�  &	        &	      &	 I       5
   
   6"   �� 5   
   .R�5      �� ��6   �� 5      �� 5   
   " ��6    5      �� 5       6   �� $ UserControl��$
 Suit� Club5      .a�5      ��  � ��$ Images\Clubs.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit�	 Heart5      .a�5      ��  � ��$ Images\Hearts.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit� Diamond5      .a�5      ��  � ��$ Images\Diamonds.png��6/   5      �� 5       6   �� $ UserControl��$
 Suit�	 Spade5      .a�5      ��  � ��$ Images\Spades.png��6/   5      5!      5"      .��5#      � .+�5$   
   �� 	 �� RadiusX$
	 12.5��6&   
 �� RadiusY$

 12.5��65   ��6   Z� ��5%      �� 5&       �� EndPoint$ 0.47,-0.167&�6&    �� 
StartPoint$ 	0.86,0.92&�6=   .��5'      �  � Color$ 	#FFD1C78F��6#    � Offset$ 0Q�65   � 5(      $ 	#FFFFFFFF��6#   $ 1Q�65   5)       J� Effect 5+      3  -System.Windows.Media.Effects.DropShadowEffect  5,         	Direction$	 145Q�6#      
BlurRadius$ 10Q�63      ShadowDepth$ 0Q�6C   5.      �� 5/   
   -   5         ��Name$ 	SuitLabel��5/      #���  51      $��Center=�52      $��Center=�6$   $��	8,51,8,60q�53      ��50      �� $
 Suit�$ UserControl�� �� Mode$ Default=�53      �� 54   
   -   5        $ 	RankLabel��54       K� ZIndex$ 1��6$   #���  57      $
��Left=�58      $	��Top=�6"   $��8,8,0,0q�59      ��55      �� $
 Rank�$ UserControl��$ Default=� �� 	Converter# [  59      �� 5:   
   -   5        $ RankLabelInverted��5:      #���  5=      $��Right=�5>      $��Bottom=�6#   $��0,0,8,8q�5?       J� RenderTransformOrigin$ 0.5,0.5&�6   ��5;      �� $
 Rank�$ UserControl��$ Default=�# [  z�5@      �� 5A       �� Angle$	 180Q�6"   5C      �� 5D   
   -   5        $��TopRightImage��5D      #��[ 6%   $��	12,12,8,0q�5E      $��Right=�6   $	��Top=�60   $
��18.5��5F      $
��18.5��6   $��UniformToFill=�6   �� 5G   
   -   5        $��BottomLeftImage��5G      #��[ 6'   $��	12,0,8,12q�5H      $
��Left=�6   $��Bottom=�6/   $
��18.5��5I      $
��18.5��6   $��UniformToFill=�6   $ 0.5,0.5&�5J      z�5K      �� 5L      $	 180Q�6"   5N      F� 5O   
   ���	#FFFFFFFF �� Stretch$
 Fill=�6    $��0,0,35.218,-0.077q�5P      �������2
�	��2
�H'�Ӓ�s�nQf�L�`@@��ӾT����
�	n�֤	���Ѡ� ��Ә�, ���\��\��\��-р\����Ӏ\�ח_��,�2
���2
��5O   /   Z�  J� OpacityMask 5T      �� 5U      $ 0.957,1.127&�6&   $ 0,-0.06&�6=   .��5V      � $ 	#FF000000��6#   $ 0Q�65   � 5W      $ 	#00FFFFFF��6#   $ 1Q�65   5X      5Z      5[      5\      