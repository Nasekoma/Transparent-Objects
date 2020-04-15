#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;
uniform vec3 MoreColor;

void main()
{    
    FragColor = vec4(vec3(texture(texture1, TexCoords)) * MoreColor, 1.0f);
}

