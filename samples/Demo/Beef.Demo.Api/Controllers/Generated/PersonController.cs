/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options

using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Beef;
using Beef.AspNetCore.WebApi;
using Beef.Entities;
using Beef.Demo.Business;
using Beef.Demo.Common.Entities;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Api.Controllers
{
    /// <summary>
    /// Provides the <b>Person</b> Web API functionality.
    /// </summary>
    [Route("api/v1/persons")]
    public partial class PersonController : ControllerBase
    {
        private readonly IPersonManager _manager;
        
        /// <summary>
        /// Parameterless constructor is explictly not supported.
        /// </summary>
        private PersonController() => throw new NotSupportedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController"/> class.
        /// </summary>
        /// <param name="manager">The <see cref="IPersonManager"/>.</param>
        public PersonController(IPersonManager manager) => _manager = Check.NotNull(manager, nameof(manager));

        /// <summary>
        /// Creates the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> entity.</param>
        /// <returns>The created <see cref="Person"/> entity.</returns>
        [HttpPost()]
        [Route("")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.Created)]
        public IActionResult Create([FromBody] Person value)
        {
            return new WebApiPost<Person>(this, () => _manager.CreateAsync(WebApiActionBase.Value(value)),
                operationType: OperationType.Create, statusCode: HttpStatusCode.Created, alternateStatusCode: null);
        }

        /// <summary>
        /// Deletes the <see cref="Person"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        [HttpDelete()]
        [Route("{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Delete(Guid id)
        {
            return new WebApiDelete(this, () => _manager.DeleteAsync(id),
                operationType: OperationType.Delete, statusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> entity where found.</returns>
        [HttpGet()]
        [Route("{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get(Guid id)
        {
            return new WebApiGet<Person?>(this, () => _manager.GetAsync(id),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Updates the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> entity.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="Person"/> entity.</returns>
        [HttpPut()]
        [Route("{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public IActionResult Update([FromBody] Person value, Guid id)
        {
            return new WebApiPut<Person>(this, () => _manager.UpdateAsync(WebApiActionBase.Value(value), id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Patches the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="JToken"/> value that contains the patch content for the entity.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The patched <see cref="Person"/> entity.</returns>
        [HttpPatch()]
        [Route("{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public IActionResult Patch([FromBody] JToken value, Guid id)
        {
            return new WebApiPatch<Person>(this, value, () => _manager.GetAsync(id), (__value) => _manager.UpdateAsync(__value, id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <returns>A <see cref="PersonCollection"/>.</returns>
        [HttpGet()]
        [Route("all")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetAll()
        {
            return new WebApiGet<PersonCollectionResult, PersonCollection, Person>(this, () => _manager.GetAllAsync(WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <returns>A <see cref="PersonCollection"/>.</returns>
        [HttpGet()]
        [Route("allnopaging")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetAll2()
        {
            return new WebApiGet<PersonCollectionResult, PersonCollection, Person>(this, () => _manager.GetAll2Async(),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="Gender"/>).</param>
        /// <returns>A <see cref="PersonCollection"/>.</returns>
        [HttpGet()]
        [Route("")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetByArgs(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return new WebApiGet<PersonCollectionResult, PersonCollection, Person>(this, () => _manager.GetByArgsAsync(args, WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="Gender"/>).</param>
        /// <returns>A <see cref="PersonDetailCollection"/>.</returns>
        [HttpGet()]
        [Route("argsdetail")]
        [ProducesResponseType(typeof(PersonDetailCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetDetailByArgs(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return new WebApiGet<PersonDetailCollectionResult, PersonDetailCollection, PersonDetail>(this, () => _manager.GetDetailByArgsAsync(args, WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Merge first <see cref="Person"/> into second.
        /// </summary>
        /// <param name="fromId">The from <see cref="Person"/> identifier.</param>
        /// <param name="toId">The to <see cref="Person"/> identifier.</param>
        /// <returns>A resultant <see cref="Person"/>.</returns>
        [HttpPost]
        [Route("merge")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public IActionResult Merge(Guid fromId, Guid toId)
        {
            return new WebApiPost<Person>(this, () => _manager.MergeAsync(fromId, toId),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Mark <see cref="Person"/>.
        /// </summary>
        [HttpPost]
        [Route("mark")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public IActionResult Mark()
        {
            return new WebApiPost(this, () => _manager.MarkAsync(),
                operationType: OperationType.Update, statusCode: HttpStatusCode.Accepted);
        }

        /// <summary>
        /// Get <see cref="Person"/> at specified <see cref="MapCoordinates"/>.
        /// </summary>
        /// <param name="coordinates">The Coordinates (see <see cref="MapCoordinates"/>).</param>
        /// <returns>A resultant <see cref="MapCoordinates"/>.</returns>
        [HttpPost]
        [Route("map")]
        [ProducesResponseType(typeof(MapCoordinates), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Map(string? coordinates = default)
        {
            var args = new MapArgs { Coordinates = new MapCoordinatesToStringConverter().ConvertToSrce(coordinates) };
            return new WebApiPost<MapCoordinates>(this, () => _manager.MapAsync(args),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="PersonDetail"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="PersonDetail"/> entity where found.</returns>
        [HttpGet()]
        [Route("{id}/detail")]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetDetail(Guid id)
        {
            return new WebApiGet<PersonDetail?>(this, () => _manager.GetDetailAsync(id),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Updates the <see cref="PersonDetail"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="PersonDetail"/> entity.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="PersonDetail"/> entity.</returns>
        [HttpPut()]
        [Route("{id}/detail")]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        public IActionResult UpdateDetail([FromBody] PersonDetail value, Guid id)
        {
            return new WebApiPut<PersonDetail>(this, () => _manager.UpdateDetailAsync(WebApiActionBase.Value(value), id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Patches the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="JToken"/> value that contains the patch content for the entity.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The patched <see cref="PersonDetail"/> entity.</returns>
        [HttpPatch()]
        [Route("{id}/detail")]
        [ProducesResponseType(typeof(PersonDetail), (int)HttpStatusCode.OK)]
        public IActionResult PatchDetail([FromBody] JToken value, Guid id)
        {
            return new WebApiPatch<PersonDetail>(this, value, () => _manager.GetDetailAsync(id), (__value) => _manager.UpdateDetailAsync(__value, id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Actually validating the FromBody parameter generation.
        /// </summary>
        /// <param name="person">The Person (see <see cref="Person"/>).</param>
        [HttpPost]
        [Route("fromBody")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public IActionResult Add([FromBody] Person? person)
        {
            return new WebApiPost(this, () => _manager.AddAsync(person),
                operationType: OperationType.Unspecified, statusCode: HttpStatusCode.Created);
        }

        /// <summary>
        /// Get Null.
        /// </summary>
        /// <param name="name">The Name.</param>
        /// <returns>A resultant <see cref="Person?"/>.</returns>
        [HttpGet]
        [Route("null")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetNull(string? name)
        {
            return new WebApiGet<Person?>(this, () => _manager.GetNullAsync(name),
                operationType: OperationType.Unspecified, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> collection entity that matches the selection criteria.
        /// </summary>
        /// <param name="firstName">The First Name.</param>
        /// <param name="lastName">The Last Name.</param>
        /// <param name="genders">The Genders (see <see cref="Gender"/>).</param>
        /// <returns>A <see cref="PersonCollection"/>.</returns>
        [HttpGet()]
        [Route("args")]
        [ProducesResponseType(typeof(PersonCollection), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult GetByArgsWithEf(string? firstName = default, string? lastName = default, List<string>? genders = default)
        {
            var args = new PersonArgs { FirstName = firstName, LastName = lastName, GendersSids = genders };
            return new WebApiGet<PersonCollectionResult, PersonCollection, Person>(this, () => _manager.GetByArgsWithEfAsync(args, WebApiQueryString.CreatePagingArgs(this)),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Throw Error.
        /// </summary>
        [HttpPost]
        [Route("error")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult ThrowError()
        {
            return new WebApiPost(this, () => _manager.ThrowErrorAsync(),
                operationType: OperationType.Unspecified, statusCode: HttpStatusCode.NoContent);
        }

        /// <summary>
        /// Gets the <see cref="Person"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The selected <see cref="Person"/> entity where found.</returns>
        [HttpGet()]
        [Route("ef/{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetWithEf(Guid id)
        {
            return new WebApiGet<Person?>(this, () => _manager.GetWithEfAsync(id),
                operationType: OperationType.Read, statusCode: HttpStatusCode.OK, alternateStatusCode: HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Creates the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> entity.</param>
        /// <returns>The created <see cref="Person"/> entity.</returns>
        [HttpPost()]
        [Route("ef")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.Created)]
        public IActionResult CreateWithEf([FromBody] Person value)
        {
            return new WebApiPost<Person>(this, () => _manager.CreateWithEfAsync(WebApiActionBase.Value(value)),
                operationType: OperationType.Create, statusCode: HttpStatusCode.Created, alternateStatusCode: null);
        }

        /// <summary>
        /// Updates the <see cref="Person"/> entity.
        /// </summary>
        /// <param name="value">The <see cref="Person"/> entity.</param>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        /// <returns>The updated <see cref="Person"/> entity.</returns>
        [HttpPut()]
        [Route("ef/{id}")]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public IActionResult UpdateWithEf([FromBody] Person value, Guid id)
        {
            return new WebApiPut<Person>(this, () => _manager.UpdateWithEfAsync(WebApiActionBase.Value(value), id),
                operationType: OperationType.Update, statusCode: HttpStatusCode.OK, alternateStatusCode: null);
        }

        /// <summary>
        /// Deletes the <see cref="Person"/> entity that matches the selection criteria.
        /// </summary>
        /// <param name="id">The <see cref="Person"/> identifier.</param>
        [HttpDelete()]
        [Route("ef/{id}")]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult DeleteWithEf(Guid id)
        {
            return new WebApiDelete(this, () => _manager.DeleteWithEfAsync(id),
                operationType: OperationType.Delete, statusCode: HttpStatusCode.NoContent);
        }
    }
}

#pragma warning restore IDE0005
#nullable restore