#!/bin/bash
F="danh-sach-bai.md"
for f in $(find -name "TODO.md" | sort); do
  iconv $f | awk -F '.' '{print $2}' | sed 's/^ //' | sed '/^$/d' >> $F
done
mv $F $F~
cat $F~ | awk '{print NR ". " $0}' >> $F
rm $F~
