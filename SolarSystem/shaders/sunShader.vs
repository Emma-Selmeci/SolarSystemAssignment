#version 400 core
layout (location = 0) in vec3 aPos;
layout (location = 1) in vec3 aNormal;
layout (location = 2) in vec2 aTex;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

out vec2 texCoord;

void main() {
	texCoord = vec2(aTex.x/10, aTex.y);
	gl_Position = projection * view * model * vec4(aPos, 1.0);
}
