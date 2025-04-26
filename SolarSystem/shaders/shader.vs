#version 400 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTex;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;
uniform mat4 trans;
uniform int id;

out vec2 texCoord;
out vec3 worldSpace;
out vec3 normal;

void main() {
	//normal = aNormal;
	normal = vec3(model * vec4(aNormal,1.0));
	texCoord = vec2(aTex.x/10 + id*0.1, aTex.y);
	gl_Position = projection * view * trans * model * vec4(aPos, 1.0);
	worldSpace = vec3(trans * model * vec4(aPos, 1.0));
}
