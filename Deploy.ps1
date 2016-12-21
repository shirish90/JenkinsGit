function Deployment
{
  param([string]$filepath,[string]$deployDestination)
  $datetime = Get-Date
  $filetext = "Deployed package to " + $deployDestination + " on " + $datetime
  $filetext | Out-File -filepath $filepath -Append
}

Deployment $args[0] $args[1]