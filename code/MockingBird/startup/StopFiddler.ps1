# get Firefox process
$fiddlerInstance = Get-Process Fiddler -ErrorAction SilentlyContinue
if ($fiddlerInstance) {
  # try gracefully first
  $fiddlerInstance.CloseMainWindow()
  # kill after five seconds
  Sleep 5
  if (!$fiddlerInstance.HasExited) {
    $fiddlerInstance | Stop-Process -Force
  }
}