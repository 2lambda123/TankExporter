﻿#version 130
//camoExporter_vertex.glsl
out vec2 TC1;
void main(void) {

    TC1 = gl_MultiTexCoord0.xy;
    gl_Position    = ftransform();

}