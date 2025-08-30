IsInstalled()
{
	if command -v $1 &> /dev/null; then
		return 0
	fi
	return 1
}

cmd=""
if IsInstalled konsole; then
	cmd="konsole -e"
elif IsInstalled gnome-terminal; then
	cmd="gnome-terminal --"
elif IsInstalled terminator; then
	cmd="terminator -e"
elif IsInstalled xterm; then
	cmd="xterm -e"
fi
echo "$cmd"
