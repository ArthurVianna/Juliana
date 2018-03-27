#pragma strict
var mesh:Transform;
var tempo:float;
var LigaDesliga:boolean;
function Update()
{ if (Input.GetKeyDown("space")){
  Application.LoadLevel (1);
  }
  tempo+=Time.deltaTime;
  if (tempo > 0.5f && LigaDesliga == false)
  {
  LigaDesliga = true;
  tempo = 0f;
  mesh.position.z = -1;
  }
  else if (tempo > 0.5f && LigaDesliga == true)
  {
  LigaDesliga = false;
  tempo = 0f;
  mesh.position.z = 1;
  }
  }