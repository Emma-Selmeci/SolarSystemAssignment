#version 400 core

in vec2 texCoord;

out vec4 fragColor;

uniform sampler2D texture1;

void main() {
    fragColor = texture(texture1, texCoord);
    //fragColor = (diff / (0.2 * length(worldSpace)) + 0.15) * texture(texture1, texCoord);
}
