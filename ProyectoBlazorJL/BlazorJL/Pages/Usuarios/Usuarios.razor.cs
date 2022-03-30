using BlazorJL.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace BlazorJL.Pages.Usuarios;

    partial class Usuarios
    {
        [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

        private IEnumerable<Usuario> usuariosLista { get; set; }


        protected override async Task OnInitializedAsync()
        {
            usuariosLista = await _usuarioServicio.GetLista();
        }
        
    //protected async Task OnInitAsync()
    //{
    //     usuariosLista = await _usuarioServicio.GetLista();
    //}


    }


    

