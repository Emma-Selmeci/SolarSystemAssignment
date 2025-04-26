#version 400 core

in vec2 texCoord;
in vec3 normal;
in vec3 worldSpace;

out vec4 fragColor;

uniform sampler2D texture1;

uniform vec3 lightPos;
uniform vec3 lightDir;
uniform float cutOff;

void main() {
    vec3 dir = normalize(lightPos - worldSpace).xyz;
    float theta = dot(dir, normalize(-lightDir).xyz); 

    vec3 norm = normalize(normal);
    float dirDiff;
    float staticDiff = max(dot(norm, normalize(-worldSpace)), 0.0);

    if(theta > cutOff) {
        dirDiff = max(dot(norm, dir), 0.0) / distance(worldSpace,lightPos) * 2;
    } else {
        dirDiff = 0;
    }

    fragColor = (staticDiff / (0.2 * length(worldSpace)) + dirDiff + 0.15) * texture(texture1, texCoord);
    //fragColor = (diff / (0.2 * length(worldSpace)) + 0.15) * texture(texture1, texCoord);
}
