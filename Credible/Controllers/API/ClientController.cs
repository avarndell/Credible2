using AutoMapper;
using Credible.DTO;
using Credible.Models;
using Credible.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Credible.Controllers.API
{
    [RoutePrefix("api/client")]
    public class ClientController : ApiController
    {
        private CredibleEntities db;

        public ClientController (){
            db = new CredibleEntities();
        }

        /// <summary>
        /// Get a list of clients
        /// </summary>
        /// <returns></returns>
        [Route("clients")]
        [HttpGet]
        public async Task<List<ClientsDto>> GetClients()
        {
            try
            {
                List<Clients> clients = new List<Clients>();
                var portalClients = await db.u_portal.OrderBy(x=> x.portal_nm).ToListAsync();

                    if (portalClients.Count> 0)
                    {
                        foreach (var item in portalClients)
                        {
                            var newClient = new Clients
                            {
                                Id = item.portal_id,
                                Name = item.portal_nm
                            };
                            clients.Add(newClient);
                        }
                }
                return Mapper.Map<List<Clients>, List<ClientsDto>>(clients);
            }
            catch (Exception)
            {

                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Gets the list of courses by clientid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("courses/{id}")]
        [HttpGet]
        public async Task<List<ClientCoursesDto>> GetClientCourses(int id){

            try
            {
                List<ClientCourses> cCourses = new List<ClientCourses>();
                var courses = await db.u_course_portal.Where(x => x.portal_id == id).OrderBy(x=> x.course_portal_nm).ToListAsync();

                if(courses.Count > 0){
                    foreach (var item in courses)
                    {
                        var newCourse = new ClientCourses
                        {
                            CourseName = item.course_portal_nm,
                            CoursePortalID = item.course_portal_id
                        };
                        cCourses.Add(newCourse);
                    }
                }
                return Mapper.Map<List<ClientCourses>, List<ClientCoursesDto>>(cCourses);
            }
            catch (Exception)
            {

                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Gets a list of registration for a given course Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("registrants/{id}")]
        [HttpGet]
        public async Task<List<RegistrantsDto>> GetRegistrants (int id)
        {
            try
            {
                List<Registrants> registrants = new List<Registrants>();

                var regs = await db.u_registration.Where(x => x.course_portal_id == id).OrderBy(x=> x.u_user.last_nm).ToListAsync();

                if(regs.Count >0){
                    foreach (var item in regs)
                    {

                        var newReg = new Registrants
                        {
                            UserId = item.user_id,
                            FirstName = item.u_user.first_nm,
                            LastName = item.u_user.last_nm,
                            RegistrationDate = item.registration_dttm,
                            RegistrationId = item.registration_id
                        };
                        registrants.Add(newReg);
                    }
                }
                return Mapper.Map<List<Registrants>, List<RegistrantsDto>>(registrants); ;
            }
            catch (Exception)
            {

                throw new HttpResponseException(HttpStatusCode.InternalServerError);
            }
        }
    }
}
