$fmt = "{0,15:N3} {1,-15} {2, 15:c2}"
$fmt -f  "Right Justified", 'Left Justified', "Right" 
$fmt -f  "---------------", '--------------', "_____"    #  minus signs or underlines
$fmt -f  10.2344, "Text", 11.1
$fmt -f  10.2345, "Text", 11.1
$fmt -f  3.2, "A bit more text", 222211.133
