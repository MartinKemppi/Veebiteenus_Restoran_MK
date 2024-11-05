using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restoran_API.Data;
using Restoran_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Restoran_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestoranController : ControllerBase
    {
        private readonly DBContext _context;

        public RestoranController(DBContext context)
        {
            _context = context;
        }

        // ------------------ TOODE ------------------
        [HttpGet("toode")]
        public List<Toode> GetToode()
        {
            return _context.Tooded.ToList();
        }

        [HttpPost("toode")]
        public List<Toode> PostToode([FromBody] Toode toode)
        {
            _context.Tooded.Add(toode);
            _context.SaveChanges();
            return _context.Tooded.ToList();
        }

        [HttpDelete("toode/{id}")]
        public List<Toode> DeleteToode(int id)
        {
            var toode = _context.Tooded.Find(id);
            if (toode != null)
            {
                _context.Tooded.Remove(toode);
                _context.SaveChanges();
            }
            return _context.Tooded.ToList();
        }

        [HttpGet("toode/{id}")]
        public ActionResult<Toode> GetToodeID(int id)
        {
            var toode = _context.Tooded.Find(id);
            if (toode == null)
            {
                return NotFound();
            }
            return toode;
        }

        [HttpPut("toode/{id}")]
        public ActionResult<List<Toode>> PutToode(int id, [FromBody] Toode updatedToode)
        {
            var toode = _context.Tooded.Find(id);
            if (toode == null)
            {
                return NotFound();
            }

            toode.Nimi = updatedToode.Nimi;
            toode.Hind = updatedToode.Hind;

            _context.Tooded.Update(toode);
            _context.SaveChanges();

            return Ok(_context.Tooded);
        }

        // ------------------ ARVE ------------------
        [HttpGet("arve")]
        public List<Arve> GetArve()
        {
            return _context.Arved.ToList();
        }

        [HttpPost("arve")]
        public List<Arve> PostArve([FromBody] Arve arve)
        {
            _context.Arved.Add(arve);
            _context.SaveChanges();
            return _context.Arved.ToList();
        }

        [HttpDelete("arve/{id}")]
        public List<Arve> DeleteArve(int id)
        {
            var arve = _context.Arved.Find(id);
            if (arve != null)
            {
                _context.Arved.Remove(arve);
                _context.SaveChanges();
            }
            return _context.Arved.ToList();
        }

        [HttpGet("arve/{id}")]
        public ActionResult<Arve> GetArveID(int id)
        {
            var arve = _context.Arved.Find(id);
            if (arve == null)
            {
                return NotFound();
            }
            return arve;
        }

        [HttpPut("arve/{id}")]
        public ActionResult<List<Arve>> PutArve(int id, [FromBody] Arve updatedArve)
        {
            var arve = _context.Arved.Find(id);
            if (arve == null)
            {
                return NotFound();
            }

            arve.Tellimus_Id = updatedArve.Tellimus_Id;
            arve.Hind = updatedArve.Hind;

            _context.Arved.Update(arve);
            _context.SaveChanges();

            return Ok(_context.Arved);
        }

        // ------------------ KASUTAJA ------------------
        [HttpGet("kasutaja")]
        public List<Kasutaja> GetKasutaja()
        {
            return _context.Kasutajad.ToList();
        }

        [HttpPost("kasutaja")]
        public List<Kasutaja> PostKasutaja([FromBody] Kasutaja kasutaja)
        {
            if (kasutaja != null && !string.IsNullOrEmpty(kasutaja.Salasona))
            {
                kasutaja.Salasona = BCrypt.Net.BCrypt.HashPassword(kasutaja.Salasona);
            }

            _context.Kasutajad.Add(kasutaja);
            _context.SaveChanges();
            return _context.Kasutajad.ToList();
        }

        [HttpDelete("kasutaja/{id}")]
        public List<Kasutaja> DeleteKasutaja(int id)
        {
            var kasutaja = _context.Kasutajad.Find(id);
            if (kasutaja != null)
            {
                _context.Kasutajad.Remove(kasutaja);
                _context.SaveChanges();
            }
            return _context.Kasutajad.ToList();
        }

        [HttpGet("kasutaja/{id}")]
        public ActionResult<Kasutaja> GetKasutajaID(int id)
        {
            var kasutaja = _context.Kasutajad.Find(id);
            if (kasutaja == null)
            {
                return NotFound();
            }
            return kasutaja;
        }

        [HttpPut("kasutaja/{id}")]
        public ActionResult<List<Kasutaja>> PutKasutaja(int id, [FromBody] Kasutaja updatedKasutaja)
        {
            var kasutaja = _context.Kasutajad.Find(id);
            if (kasutaja == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(updatedKasutaja.Salasona))
            {
                updatedKasutaja.Salasona = BCrypt.Net.BCrypt.HashPassword(updatedKasutaja.Salasona);
            }

            kasutaja.KasutajaNimi = updatedKasutaja.KasutajaNimi;
            kasutaja.Salasona = updatedKasutaja.Salasona;
            kasutaja.Roll = updatedKasutaja.Roll;

            _context.Kasutajad.Update(kasutaja);
            _context.SaveChanges();

            return Ok(_context.Kasutajad);
        }

        // ------------------ RESTORAN ------------------
        [HttpGet("restoran")]
        public List<Restoran> GetRestoran()
        {
            return _context.Restoranid.ToList();
        }

        [HttpPost("restoran")]
        public List<Restoran> PostRestoran([FromBody] Restoran restoran)
        {
            _context.Restoranid.Add(restoran);
            _context.SaveChanges();
            return _context.Restoranid.ToList();
        }

        [HttpDelete("restoran/{id}")]
        public List<Restoran> DeleteRestoran(int id)
        {
            var restoran = _context.Restoranid.Find(id);
            if (restoran != null)
            {
                _context.Restoranid.Remove(restoran);
                _context.SaveChanges();
            }
            return _context.Restoranid.ToList();
        }

        [HttpGet("restoran/{id}")]
        public ActionResult<Restoran> GetRestoranID(int id)
        {
            var restoran = _context.Restoranid.Find(id);
            if (restoran == null)
            {
                return NotFound();
            }
            return restoran;
        }

        [HttpPut("restoran/{id}")]
        public ActionResult<List<Restoran>> PutRestoran(int id, [FromBody] Restoran updatedRestoran)
        {
            var restoran = _context.Restoranid.Find(id);
            if (restoran == null)
            {
                return NotFound();
            }

            restoran.Nimi = updatedRestoran.Nimi;
            restoran.Laud = updatedRestoran.Laud;
            restoran.LauadeMahutavus = updatedRestoran.LauadeMahutavus;
            restoran.Tagid = updatedRestoran.Tagid;

            _context.Restoranid.Update(restoran);
            _context.SaveChanges();

            return Ok(_context.Restoranid);
        }

        // ------------------ TELLIMUS ------------------
        [HttpGet("tellimus")]
        public List<Tellimus> GetTellimus()
        {
            return _context.Tellimused.ToList();
        }

        [HttpPost("tellimus")]
        public List<Tellimus> PostTellimus([FromBody] Tellimus tellimus)
        {
            _context.Tellimused.Add(tellimus);
            _context.SaveChanges();
            return _context.Tellimused.ToList();
        }

        [HttpDelete("tellimus/{id}")]
        public List<Tellimus> DeleteTellimus(int id)
        {
            var tellimus = _context.Tellimused.Find(id);
            if (tellimus != null)
            {
                _context.Tellimused.Remove(tellimus);
                _context.SaveChanges();
            }
            return _context.Tellimused.ToList();
        }

        [HttpGet("tellimus/{id}")]
        public ActionResult<Tellimus> GetTellimusID(int id)
        {
            var tellimus = _context.Tellimused.Find(id);
            if (tellimus == null)
            {
                return NotFound();
            }
            return tellimus;
        }

        [HttpPut("tellimus/{id}")]
        public ActionResult<List<Tellimus>> PutTellimus(int id, [FromBody] Tellimus updatedTellimus)
        {
            var tellimus = _context.Tellimused.Find(id);
            if (tellimus == null)
            {
                return NotFound();
            }

            tellimus.Kasutaja = updatedTellimus.Kasutaja;
            tellimus.TooteNimed = updatedTellimus.TooteNimed;
            tellimus.Kogused = updatedTellimus.Kogused;
            tellimus.Hind = updatedTellimus.Hind;
            tellimus.Laud = updatedTellimus.Laud;
            tellimus.Komentaar = updatedTellimus.Komentaar;
            tellimus.Seisukord = updatedTellimus.Seisukord;

            _context.Tellimused.Update(tellimus);
            _context.SaveChanges();

            return Ok(_context.Tellimused);
        }
    }
}