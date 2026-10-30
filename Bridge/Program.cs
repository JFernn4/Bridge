using Bridge;

ICanal canalFalla = new CanalFalsoFalla();
ICanal canalRespaldo = new CanalEmail();

// Se configuran el canal principal y el de respaldo
Notificacion notificacion = new NotificacionUrgente(canalFalla, canalRespaldo);

string correo = "ana@uni.edu";

//cambia al respaldo y envía
notificacion.Enviar(correo, "reunion a las 18");

//sobre el canal de respaldo (sin aviso de cambio
notificacion.Enviar(correo, "traigan sus computadoras");